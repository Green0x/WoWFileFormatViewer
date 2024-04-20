namespace WoWFileFormats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string filename = "lights.lit";
            BinaryReader bw = new BinaryReader(File.OpenRead(filename));
            UInt32 version = bw.ReadUInt32();
            Int32 lightCount = bw.ReadInt32();
            //Begin lightListData
            Console.WriteLine("Version: {0}", printVersion(version));
            Console.WriteLine("Number of lights: {0}", lightCount);

            Dictionary<long, string> lightMap = new Dictionary<long, string>();

            for (int i = 0; i < lightCount; i++)
            {
                long chunkPos = bw.BaseStream.Position;
                //C2iVector
                int m_chunkX = bw.ReadInt32();
                int m_chunkY = bw.ReadInt32();
                //C2iVector
                Int32 m_chunkRadius = bw.ReadInt32();
                //C3Vector - 3 floats x,y,z
                float cordinateX = bw.ReadSingle();
                float cordinateY = bw.ReadSingle();
                float cordinateZ = bw.ReadSingle();
                //C3Vector
                float lightRadius = bw.ReadSingle();
                float lightDropoff = bw.ReadSingle();
                byte[] name = bw.ReadBytes(32);

                lightMap.Add(chunkPos, System.Text.Encoding.ASCII.GetString(name));
                Console.WriteLine("Light Name: {0}", System.Text.Encoding.Default.GetString(name));
                Console.WriteLine("m_chunk x: {0}, y: {1}", m_chunkX, m_chunkY);
                Console.WriteLine("m_chunkRadius: {0}", m_chunkRadius);
                Console.WriteLine("Co-ordinates x: {0}, y: {1}, z: {2}", cordinateX, cordinateY, cordinateZ);
                Console.WriteLine("Light Radius: {0}", lightRadius / 36);
                Console.WriteLine("Light Dropoff: {0}", lightDropoff / 36);
                Console.WriteLine("");
            }
            foreach (var item in lightMap)
            {
                litNameBox.Items.Add(item.Value); // When updating the names of lights Blizzard didn't overwrite names
                                                  // correctly, leading to some extra parts of the overwritten name
                                                  // remaining. We just ignore those extra bytes.
            }
        }

        static string printVersion(UInt32 num)
        {
            return num.ToString("X").Remove(1, 6).Insert(1, ".");
        }
    }
}

