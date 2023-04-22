using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ManagerApp
{
    public partial class NewAddStudentForm : Form
    {
        public string Pic = null;
        public NewAddStudentForm()
        {
            InitializeComponent();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                string SQL2 = @"insert into Students(
الاسم,
الحالة,
العمر,
جوال,
مرحلة,
حلقة,
حفظ,
تلاوة,
مكفل,
انذار,
اسم_المعلم,
تاريخ_التسجيل,
مدرسة,
وظيفته,
وظيفة_الاب,
رقم_الاب,
وظيفة_الام,
رقم_الام,
المستوى_الدراسي,
التخصص,
محل_الاقامة,
ملكية,
ايام_الحضور,
وقت_الحضور,
الحالة_المعيشية,
اسم_الولي,
القرابة_منه,
رقم_الولي,
ملاحظات,
الصورة,
الجنس,
الحالة_الاجتماعية
)
values(
@name,
@hale,
@age,
@mob,
@mrhle,
@hlqa,
@save,
@telawa,
@mkfl,
@warning,
@teacher,
@date,
@school,
@job,
@dadjob,
@dadmob,
@momjob,
@mommob,@study,@sp,@house,@mlkea,@days,@times,@halem3,@wlename,@qraba,@wlemob,@notes,@pic,@sex,@social
)";
                command.Connection = ConnectionClass.Connection;
                command.CommandText = SQL2;
                command.Parameters.AddWithValue("@name", nameTB.Text);
                command.Parameters.AddWithValue("@hale", hale.SelectedItem);
                command.Parameters.AddWithValue("@age", age.Text);
                command.Parameters.AddWithValue("@mob", mobile.Text);
                command.Parameters.AddWithValue("@mrhle", mrhle.SelectedItem);
                command.Parameters.AddWithValue("@hlqa", hlqa.SelectedItem);
                command.Parameters.AddWithValue("@save", int.Parse(save.Text));
                command.Parameters.AddWithValue("@telawa", int.Parse(telawa.Text));
                command.Parameters.AddWithValue("@mkfl", mkfl.SelectedItem);
                command.Parameters.AddWithValue("@warning", int.Parse(warning.Text));
                command.Parameters.AddWithValue("@teacher", teacherNameTB.Text);
                command.Parameters.AddWithValue("@date", datePicker.Value);
                command.Parameters.AddWithValue("@school", schoolTB.Text);
                command.Parameters.AddWithValue("@job", job.Text);
                command.Parameters.AddWithValue("@dadjob", dadjob.Text);
                command.Parameters.AddWithValue("@dadmob", dadmob.Text);
                command.Parameters.AddWithValue("@momjob", momjob.Text);
                command.Parameters.AddWithValue("@mommob", mommob.Text);
                command.Parameters.AddWithValue("@study", study.Text);
                command.Parameters.AddWithValue("@sp", sp.Text);
                command.Parameters.AddWithValue("@house", house.Text);
                command.Parameters.AddWithValue("@mlkea", mlkea.Text);
                command.Parameters.AddWithValue("@days", days.Text);
                command.Parameters.AddWithValue("@times", times.Text);
                command.Parameters.AddWithValue("@halem3", halem3eshea.SelectedItem);
                command.Parameters.AddWithValue("@wlename", wlename.Text);
                command.Parameters.AddWithValue("@qraba", qraba.Text);
                command.Parameters.AddWithValue("@wlemob", wlemob.Text);
                command.Parameters.AddWithValue("@notes", notes.Text);
                command.Parameters.AddWithValue("@pic", Pic);
                command.Parameters.AddWithValue("@sex", sex.SelectedItem);
                command.Parameters.AddWithValue("@social", social.SelectedItem);

                if (command.ExecuteNonQuery() >= 1)
                    MessageBox.Show("تمت أضافة الطالب بنجاح");
            }
            catch(OleDbException ea)
            {
                if(ea.Message.Contains("Data"))
                MessageBox.Show("الرجاء أختيار تاريخ التسجيل");
               else
                {
                    MessageBox.Show(ea.Message);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("الرجاء التأكد من كتابة الأرقام في خاناتها الصحيحة");
            }
        }
        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            OFD.ShowDialog();
            Pic=OFD.FileName;
            gunaCirclePictureBox1.Image = Image.FromFile(Pic);
        }
    }
}
