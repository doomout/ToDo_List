using System.Data;


namespace ToDo_List.ToDo
{
    public partial class Update_View : Form
    {
        private Mode currentMode;
        private DataRow dataRow;

        public Update_View(Mode mode, DataRow row = null)
        {
            InitializeComponent();
            currentMode = mode;
            dataRow = row;
        }

        public enum Mode
        {
            Add,
            Update
        }

        private void Update_Load(object sender, EventArgs e)
        {
            // 추가 모드, 수정 모드 구분
            if (currentMode == Mode.Add)
            {
                this.Text = "할 일 추가";
                this.btn_Update.Text = "추가";
            }
            else if (currentMode == Mode.Update)
            {
                this.Text = "할 일 수정";
                this.btn_Update.Text = "수정";

                // 데이터 그리드뷰에서 정보를 가져와서 폼에 표시
                if (dataRow != null)
                {
                    txt_Title.Text = dataRow["title"].ToString();
                    txt_Description.Text = dataRow["description"].ToString();

                    // created_at 값을 DateTime으로 변환하여 MonthCalendar에 설정
                    DateTime createdAt = Convert.ToDateTime(dataRow["created_at"]);
                    mCal_create.SelectionStart = createdAt;
                    mCal_create.SelectionEnd = createdAt;

                    if (Convert.ToBoolean(dataRow["is_completed"]))
                    {
                        rdo_true.Checked = true;
                    }
                    else
                    {
                        rdo_false.Checked = true;
                    }
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
