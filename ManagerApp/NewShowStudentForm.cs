using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Spire.Doc;

namespace ManagerApp

{
    public partial class NewShowStudentForm : Form
    {
        public NewShowStudentForm()
        {
            InitializeComponent();
        }
        DataTable T = new DataTable();

        private void Back_Button_Click(object sender, EventArgs e)
        {
            NewStudentsTqarerForm NHPF = new NewStudentsTqarerForm();
            FindControl fc = new FindControl();
            NewHomeForm F = new NewHomeForm();
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Clear();
                NHPF.TopLevel = false;
                ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Add(NHPF);
                ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "Student_Panel")).Show();
                NHPF.BringToFront();
                NHPF.Show();
        }
        private void New_Student_Load(object sender, EventArgs e)
        {
        
            try
            {
                ConnectionClass.Select("Select * From Students where ر=" + NewStudentsTqarerForm.R, T);
                idTB.Text = idTB.Text + " " + NewStudentsTqarerForm.R.ToString();
                nameTB.Text = nameTB.Text + " " + T.Rows[0]["الاسم"].ToString();
                hale.Text =(T.Rows[0]["الحالة"].ToString()=="مطرود")? hale.Text + " " + T.Rows[0]["الحالة"].ToString(): hale.Text + " " + T.Rows[0]["الحالة"] + " " + gunaDateTimePicker1.Value.ToShortDateString();
                age.Text = age.Text + " " + T.Rows[0]["العمر"].ToString();
                mobile.Text = mobile.Text + " " + T.Rows[0]["جوال"].ToString();
                mrhle.Text = mrhle.Text + " " + T.Rows[0]["مرحلة"].ToString();
                hlqa.Text = hlqa.Text + " " + T.Rows[0]["حلقة"].ToString();
                gunaTextBox28.Text = gunaTextBox28.Text + " " + T.Rows[0]["غياب_اجازة"].ToString();
                save.Text = save.Text + " " + T.Rows[0]["حفظ"].ToString();
                telawa.Text = telawa.Text + " " + T.Rows[0]["تلاوة"].ToString();
                mkfl.Text = mkfl.Text + " " + T.Rows[0]["مكفل"].ToString();
                warning.Text = warning.Text + " " + T.Rows[0]["انذار"].ToString();
                teacherNameTB.Text = teacherNameTB.Text + " " + T.Rows[0]["اسم_المعلم"].ToString();
                schoolTB.Text = schoolTB.Text + " " + T.Rows[0]["مدرسة"].ToString();
                job.Text = job.Text + " " + T.Rows[0]["وظيفته"].ToString();
                dadjob.Text = dadjob.Text + " " + T.Rows[0]["وظيفة_الاب"].ToString();
                dadmob.Text = dadmob.Text + " " + T.Rows[0]["رقم_الاب"].ToString();
                momjob.Text = momjob.Text + " " + T.Rows[0]["وظيفة_الام"].ToString();
                mommob.Text = mommob.Text + " " + T.Rows[0]["رقم_الام"].ToString();
                study.Text = study.Text + " " + T.Rows[0]["المستوى_الدراسي"].ToString();
                sp.Text = sp.Text + " " + T.Rows[0]["التخصص"].ToString();
                house.Text = house.Text + " " + T.Rows[0]["محل_الاقامة"].ToString();
                mlkea.Text = mlkea.Text + " " + T.Rows[0]["ملكية"].ToString();
                days.Text = days.Text + " " + T.Rows[0]["ايام_الحضور"].ToString();
                times.Text = times.Text + " " + T.Rows[0]["وقت_الحضور"].ToString();
                halem3eshea.Text = halem3eshea.Text + " " + T.Rows[0]["الحالة_المعيشية"].ToString();
                wlename.Text = wlename.Text + " " + T.Rows[0]["اسم_الولي"].ToString();
                qraba.Text = qraba.Text + " " + T.Rows[0]["القرابة_منه"].ToString();
                wlemob.Text = wlemob.Text + " " + T.Rows[0]["رقم_الولي"].ToString();
                notes.Text = notes.Text + " " + T.Rows[0]["ملاحظات"].ToString();
                datePicker.Value = Convert.ToDateTime(T.Rows[0]["تاريخ_التسجيل"]);

                sex.Text = sex.Text + " " + T.Rows[0]["الجنس"].ToString();
                gunaCirclePictureBox1.Image = Image.FromFile(T.Rows[0]["الصورة"].ToString());
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(a.Message);
            }
            catch(IndexOutOfRangeException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (InvalidCastException a)
            {
                MessageBox.Show(a.Message);
            }
            //catch (FileNotFoundException a)
            //{
            //    MessageBox.Show(a.Message);
            //}
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            //Load the document from disk.
            Document document = new Document();
            document.LoadFromFile(@"C:\Users\Omar\Downloads\2.docx");
            //Replace text
            document.Replace("اسم الثلاثي: هنايجبكتابةالاسمالثلاثيكماهو", nameTB.Text+"  ", false, true);
            document.Replace("العمر: هناالعمر", age.Text+ "                 ", false, true);
            document.Replace("الجنس : هناالجنس", sex.Text, false, true);
            document.Replace("وظيفته الحالية: هناوظيفتهالحالية", job.Text, false, true);

            document.Replace("رقم جوال:هنارقمالجوال", mobile.Text, false, true);
            document.Replace("وظيفة زوج أو أب: هناوظيفةزوجاوب", dadjob.Text, false, true);
            document.Replace("رقمه : هنارقمزوجاواب", dadmob.Text, false, true);
            document.Replace("وظيفة أم: هناوظيفةام", momjob.Text, false, true);
            document.Replace("رقمها: هنارقمالام", mommob.Text, false, true);
            document.Replace("مستوى الدراسي: هناالمستوىالدراسي",study.Text,false,true);

            document.Replace("التخصص: هناالتخصصالدراسي ", sp.Text, false, true);
            document.Replace("محل إقامة حاليا: هنامحلالاقامةحاليا", house.Text, false, true);
            document.Replace("ملكية الدار : هناملكيةالدار", mlkea.Text, false, true);
            document.Replace("حالة اجتماعية: هناالحالةالاجتماعية", hale.Text, false, true);

            document.Replace("حالة معيشية: هنايجبكتابةالحالةالمعيشية  ", halem3eshea.Text, false, true);
            document.Replace("اسم الولي:هنااسمالولي", wlename.Text, false, true);
            document.Replace("القرابة منه:هناالقرابةمنه", qraba.Text, false, true);
            document.Replace("رقم جوال:هنارقمجوالالولي", wlemob.Text, false, true);
            document.Replace("ملاحــظة:هناملاحظات", notes.Text, false, true);



            //Save doc file.
            document.SaveToFile("Sample.docx", FileFormat.Docx);

            //Launching the MS Word file.
            WordDocViewer("Sample.docx");
        }
        private void WordDocViewer(string fileName)
        {

            try
            {

                System.Diagnostics.Process.Start(fileName);
            }
            catch { }
        }
    }
    }

