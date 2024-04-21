using System;
using System.Text;

namespace WoWFileFormats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        const string filename = "lights.lit";
        Dictionary<string, long> lightMap = new Dictionary<string, long>();
        private void button1_Click(object sender, EventArgs e)
        {
            
            BinaryReader bw = new BinaryReader(File.OpenRead(filename));
            UInt32 version = bw.ReadUInt32();
            Int32 lightCount = bw.ReadInt32();
            //Begin lightListData
            Console.WriteLine("Version: {0}", version.ToString("X").Remove(1, 6).Insert(1, "."));
            Console.WriteLine("Number of lights: {0}", lightCount);

            for (int i = 0; i < lightCount; i++)
            {
                long chunkPos = bw.BaseStream.Position;
                
                int m_chunkX = bw.ReadInt32(); // Always 0
                int m_chunkY = bw.ReadInt32(); // Always 0
                
                Int32 m_chunkRadius = bw.ReadInt32();
                
                float cordinateX = bw.ReadSingle();
                float cordinateY = bw.ReadSingle();
                float cordinateZ = bw.ReadSingle();
                
                float lightRadius = bw.ReadSingle();
                float lightDropoff = bw.ReadSingle();
                byte[] name = bw.ReadBytes(32);

                lightMap.Add(Encoding.ASCII.GetString(name), chunkPos);
                Console.WriteLine($"Light Name: {Encoding.ASCII.GetString(name)}");
                Console.WriteLine($"m_chunk x: {m_chunkX}, y: {m_chunkY}");
                Console.WriteLine($"m_chunkRadius: {m_chunkRadius}");
                Console.WriteLine($"Co-ordinates x: {cordinateX}, y: {cordinateY}, z: {cordinateZ}");
                Console.WriteLine($"Light Radius: {lightRadius / 36}");
                Console.WriteLine($"Light Dropoff: {lightDropoff / 36}\n");
            }
            foreach (var item in lightMap)
            {
                litNameBox.Items.Add(item.Key); // When updating the names of lights Blizzard didn't overwrite names
                                                // correctly, leading to some extra parts of the overwritten name being displayed.
            }
            bw.Close();
        }

        private void litNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableLightEditBoxes();
            using (BinaryReader bw = new BinaryReader(File.OpenRead(filename)))
            {
                long chunkPos = lightMap[litNameBox.SelectedItem.ToString()];
                var lightData = readChunk(bw, chunkPos);
                lgtRadius.Text = lightData.lightRadius.ToString();
                lgtDropoff.Text = lightData.lightDropoff.ToString();
                xCoordBox.Text = lightData.cordinateX.ToString();
                yCoordBox.Text = lightData.cordinateY.ToString();
                zCoordBox.Text = lightData.cordinateZ.ToString();
            }
            
        }

        private LightListData readChunk(BinaryReader br, long pos)
        {
            br.BaseStream.Seek(pos, SeekOrigin.Begin);
            
            LightListData data = new LightListData();

            data.m_chunkX = br.ReadInt32(); // Always 0
            data.m_chunkY = br.ReadInt32(); // Always 0

            data.m_chunkRadius = br.ReadInt32();

            data.cordinateX = br.ReadSingle();
            data.cordinateY = br.ReadSingle();
            data.cordinateZ = br.ReadSingle();

            data.lightRadius = br.ReadSingle();
            data.lightDropoff = br.ReadSingle();

            return data;
        }

        public struct LightListData
        {
            public int m_chunkX;
            public int m_chunkY;
            public Int32 m_chunkRadius;
            public float cordinateX;
            public float cordinateY;
            public float cordinateZ;
            public float lightRadius;
            public float lightDropoff;
        }
        private void enableLightEditBoxes()
        {
            lgtRadius.ReadOnly = false;
            lgtDropoff.ReadOnly = false;
            xCoordBox.ReadOnly = false;
            yCoordBox.ReadOnly = false;
            zCoordBox.ReadOnly = false;
        }
    }
}

