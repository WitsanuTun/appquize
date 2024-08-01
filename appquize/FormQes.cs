using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appquize
{
    public partial class FormQes : Form
    {
        public class Question
{
    public string Quest { get; set; }
    public string A { get; set; }
    public string B { get; set; }
    public string C { get; set; }
    public string D { get; set; }
    public string Image { get; set; }

    public string Result { get; set; }

    public Question(string quest, string a, string b, string c, string d, string image, string result)
    {
        Quest = quest;
        A = a;
        B = b;
        C = c;
        D = d;
        Image = image;
        Result = result;
    }
}

        private Question[] questions = new Question[]
            {
                 new Question("ทำไมไก่ถึงข้ามถนน?", "ไปหาเพื่อน", "ไปซื้อของ", "ไปฟ้องตำรวจ", "ไปข้ามถนน", "https://topicstock.pantip.com/wahkor/topicstock/2010/04/X9169348/X9169348-0.jpg", "D"),
                new Question("ทำไมไก่ถึงข้ามถนน?", "ไปหาเพื่อน", "ไปซื้อของ", "ไปฟ้องตำรวจ", "ไปข้ามถนน", "https://topicstock.pantip.com/wahkor/topicstock/2010/04/X9169348/X9169348-0.jpg", "D"),
                new Question("อะไรอยู่ใต้เท้าคุณตอนนี้?", "รองเท้า", "พื้น", "ถุงเท้า", "พื้นดิน", "https://f.ptcdn.info/226/082/000/s3nmz91tygm9wfV2xHh6B-o.jpg", "B"),
                new Question("แสงไฟอะไรที่สว่างที่สุดในโลก?", "ดวงอาทิตย์", "หลอดไฟ", "ไฟจราจร", "ไฟฉาย", "https://zeusledth.com/album/news/large/e00671e0e72dd241b1093cace3a84519.jpg", "A"),
                new Question("ทำไมคนถึงหาว?", "ง่วงนอน", "เบื่อ", "หิว", "เพื่อหายใจ", "https://res.cloudinary.com/dk0z4ums3/image/upload/v1624941772/attached_image_th/%E0%B8%AB%E0%B8%B2%E0%B8%A7-%E0%B9%80%E0%B8%81%E0%B8%B4%E0%B8%94%E0%B8%88%E0%B8%B2%E0%B8%81%E0%B8%AD%E0%B8%B0%E0%B9%84%E0%B8%A3-%E0%B8%AB%E0%B8%B2%E0%B8%A7%E0%B8%9A%E0%B9%88%E0%B8%AD%E0%B8%A2-pobpad.jpg", "D"),
                new Question("อะไรคือสิ่งที่ทุกคนมองหาแต่ไม่เคยเจอ?", "แว่นตา", "กุญแจรถ", "โชคดี", "เรื่องราวดีๆ", "https://s359.kapook.com/r/600/auto/pagebuilder/4547ff15-6ba3-41c5-a40d-c40ed25ce456.jpg", "C"),
                new Question("ถ้าคุณอยู่ในห้องที่ไม่มีประตู ไม่มีหน้าต่าง คุณจะออกไปยังไง?", "ใช้คีย์การ์ด", "เจาะกำแพง", "เรียกตำรวจ", "หยุดคิดแล้วตื่นจากฝัน", "https://f.ptcdn.info/289/077/000/rbz5jbr74fSNOoMkGvJ3-s.jpg", "D"),
                new Question("อะไรที่ทุกคนรู้แต่ไม่อยากพูดถึง?", "ความลับ", "ข้อผิดพลาด", "อายุ", "เงินเดือน", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSU--V5t6qXwsKsIv8UXGkwNEqvU5GVvoLqgA&s", "A"),
                new Question("แมวอะไรที่คนไม่กล้าเข้าใกล้?", "แมวเหมียว", "แมวป่า", "แมวดำ", "แมวสิงห์", "https://s359.kapook.com/pagebuilder/648964bc-152e-4a35-9748-38375ba876bd.jpg", "B"),
                new Question("กินอะไรแล้วร้องไห้?", "พริก", "หอม", "ข้าวโพด", "แอปเปิ้ล", "https://f.ptcdn.info/share/201901/2019010838435257.jpeg", "B"),
                new Question("ถ้ามีคนเรียกคุณว่า 'คนบ้า' คุณจะทำยังไง?", "หัวเราะ", "ร้องไห้", "โกรธ", "ปล่อยไป", "https://f.ptcdn.info/837/010/000/1381562269-hqdefault-o.jpg", "D"),

            };
        private int count = 0;

        private int point = 0;

        public FormQes()
        {
            InitializeComponent();
        }

        private void FormQes_Load(object sender, EventArgs e)
        {
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (count < questions.Length)
            {
                var data = questions[count];
                label1.Text = data.Quest;
                radioButton1.Text = data.A;
                radioButton2.Text = data.B;
                radioButton3.Text = data.C;
                radioButton4.Text = data.D;
                pictureBox1.ImageLocation = data.Image;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
            CheckAnswer("A");
            radioButton1.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                CheckAnswer("B");
                radioButton2.Checked = false;
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                CheckAnswer("C");
                radioButton3.Checked = false;
            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                CheckAnswer("D");
                radioButton4.Checked = false;
            }
        }

        private void CheckAnswer(string answer)
        {
            Question data = questions[count];
            if (data.Result == answer)
            {
                point++;
            }

            count++;

            if (count < questions.Length)
            {
                LoadQuestion();
            }
            else
            {
                FormEnd formQes = new FormEnd(point);

                formQes.Show();

                this.Close();
            }
        }
    }
}
