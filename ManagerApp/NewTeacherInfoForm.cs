using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManagerApp
{
    public partial class NewTeacherInfoForm : Form
    {
        public NewTeacherInfoForm()
        {
            InitializeComponent();
        }

        private void NewTeacherInfoForm_Load(object sender, EventArgs e)
        {
            DataTable T = new DataTable();
            ConnectionClass.Select("Select * From Teachers where ر = " + NewTeacherTaqrerForm.NumberR,T);
            NumberTB.Text    = NumberTB.Text+T.Rows[0]["ر"].ToString();
            DateTP.Value     =(DateTime) T.Rows[0]["تاريخ_التسجيل"];
            SchoolTB.Text    = SchoolTB.Text+ T.Rows[0]["مدرسة"].ToString();
            NameTB.Text      = NameTB.Text+ T.Rows[0]["الاسم"].ToString();
            WorkTB.Text      = WorkTB.Text+T.Rows[0]["مجال_العمل"].ToString();
            JobTB.Text       = JobTB.Text+T.Rows[0]["الوظيفة_الحالية"].ToString();
            MobileTB.Text    = MobileTB.Text+T.Rows[0]["الجوال"].ToString();
            FatherTB.Text    = FatherTB.Text + T.Rows[0]["وظيفة_الاب"];
            FahtherMob.Text  = FahtherMob.Text + T.Rows[0]["رقم_الاب"];
            StudyTB.Text     = StudyTB.Text + T.Rows[0]["المستوى_الدراسي"];
            SpTB.Text        = SpTB.Text + T.Rows[0]["التخصص"];
            EkamaTB.Text     = EkamaTB.Text + T.Rows[0]["محل_الاقامة"];
            HouseTB.Text     = HouseTB.Text + T.Rows[0]["ملكية_الدار"];
            DaysTB.Text      =DaysTB.Text+T.Rows[0]["ايام_الحضور"];
            TimeTB.Text      = TimeTB.Text + T.Rows[0]["وقت_الحضور"];
            HaleTB.Text      =HaleTB.Text+T.Rows[0]["الحالة_المعيشية"];
            NotesTB.Text      = NotesTB.Text + T.Rows[0]["ملاحظات"];
            DateTime DT =(DateTime) T.Rows[0]["التاريخ"];
            string  FDT= DT.ToString("dd/M/yyyy");
            HaletAlamalTB.Text= HaletAlamalTB.Text+T.Rows[0]["الحالة"]+" " +FDT;
            SexTB.Text= SexTB.Text+T.Rows[0]["الجنس"];
            SocialTB.Text= SocialTB.Text+T.Rows[0]["الحالة_الاجتماعية"];
            AgeTB.Text=AgeTB.Text+T.Rows[0]["العمر"];
            Mar7leTB.Text=Mar7leTB.Text+T.Rows[0]["المرحلة"];
            RingTB.Text=RingTB.Text+T.Rows[0]["الحلقة"];
            CheckTB.Text= CheckTB.Text+T.Rows[0]["غياب_اجازة"];
            WarningTB.Text= WarningTB.Text+T.Rows[0]["انذار"];
            T3hdTB.Text= T3hdTB.Text+T.Rows[0]["تعهد"];
            KhedmaTB.Text= KhedmaTB.Text+T.Rows[0]["الخدمة"];
            AdaaTB.Text= AdaaTB.Text+T.Rows[0]["ادائه"];
               



        }
    }
}
