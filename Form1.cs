namespace _0209_парсинг_рядка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string res = "";
            int numberMarker = 0;
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ';')
                {
                    numberMarker++;
                }
                if (numberMarker == 3 && str[i]!=';')
                {
                    res = res.Insert(index, str[i].ToString());
                    ++index;
                }
            }
            if (numberMarker >= 3)
            {
                label1.Text = $"Autor_id: {res}";
            } else
            {
                label1.Text = "Autor_id: не знайдено";
            }
            
        }
    }
}