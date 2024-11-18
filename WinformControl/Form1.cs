namespace WinformControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Yo!, Watsubbro", "First Message");
            MessageBox.Show("Hi!, Mirxcle", "Second Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("เจ้าต้องการสิปิดข่อยแม่นบ่!!", "อีหลีบ่!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true; //ยกเลิกคำสั่งปิด Form
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);
            this.BackColor = Color.FromArgb(r, g, b);
            this.Text = r.ToString() + "," + g.ToString() + "," + b.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCyan;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSlateGray;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {   //เมื่อเลื่อนเม้าส์เข้าไปที่ปุ่ม
            button2.BackColor = Color.LightCoral;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {   //เมื่อเลื่อนเม้าส์ออกจากปุ่ม
            button2.BackColor = Color.DarkViolet;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {   //เมื่อเลื่อนเม้าส์เข้าไปที่ปุ่ม
            button3.BackColor = Color.LightGoldenrodYellow;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {   //เมื่อเลื่อนเม้าส์ออกจากปุ่ม
            button3.BackColor = Color.DarkSalmon;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "มหาวิทยาลัยราชภัฏอุดรธานี")
            {
                label1.Text = "Udonthani Rajabhat University";
            }
            else
            {
                label1.Text = "มหาวิทยาลัยราชภัฏอุดรธานี";
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightSkyBlue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.BlanchedAlmond;
        }
    }
}
