using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxWinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 살기좋은 도시 초기화, 가장 기본적인 리스트박스추가
            LsbGoodCity.Items.Add("오스트리아, 빈");
            LsbGoodCity.Items.Add("호주, 멜버른");
            LsbGoodCity.Items.Add("일본, 오사카");
            LsbGoodCity.Items.Add("캐나다, 캘거리");
            LsbGoodCity.Items.Add("호주, 시드니");
            LsbGoodCity.Items.Add("캐나다, 벤쿠버");
            LsbGoodCity.Items.Add("일본, 도쿄");
            LsbGoodCity.Items.Add("캐나다, 토론토");
            LsbGoodCity.Items.Add("호주, 애들래이드");
            LsbGoodCity.Items.Add("한국, 서울");
            LsbGoodCity.Items.Add("체코, 프라하");

            // 데이터 바인딩 방식 중 하나
            List<string> lstConuntry = new List<string>()
            { "미국", "러시아", "중국", "영국", "독일", "프랑스", "일본", "이스라엘", "사우디아라비아", "UAE", "체코" };

            LsbHappyCountry.DataSource = lstConuntry;
            LsbHappyCountry.SelectedIndex = -1; // 리스트박스 초기화
        }

        private void LsbGdpCountry_SelectedIndexChanged(object sender, EventArgs e) 
            // 1. 이벤트의 delegate를 받을때 이벤트가 뭘 받을지 모르니까 object로 boxing했음
        {
            // 선택된 값 확인 MessageBox.Show(sender.ToString());
            // 2. object는 listbox의 메서드를 쓰지 못함(부모가 자식걸 못쓰듯이) 그러므로 unboxing(형변환)을 해야함
            var selItem = sender as ListBox;
            //MessageBox.Show($"{selItem.SelectedIndex.ToString()} / {selItem.SelectedItem}");
            TxtIndexGdp.Text = selItem.SelectedIndex.ToString();
            TxtItemGdp.Text = selItem.SelectedItem == null ? string.Empty : selItem.SelectedItem.ToString();
        }

        private void LsbGoodCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItem = sender as ListBox;
            TxtIndexGood.Text = selItem.SelectedIndex.ToString();
            TxtItemGood.Text = selItem.SelectedItem == null ? string.Empty : selItem.SelectedItem.ToString();
        }

        private void LsbHappyCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItem = sender as ListBox;
            TxtIndexHappy.Text = selItem.SelectedIndex.ToString();
            TxtItemHappy.Text = selItem.SelectedItem == null ? string.Empty : selItem.SelectedItem.ToString(); // 선택된 값이 없어서 생기는 오류
        }

        private void BtnFomat_Click(object sender, EventArgs e)
        {
            LsbGdpCountry.SelectedIndex = LsbGoodCity.SelectedIndex = LsbHappyCountry.SelectedIndex = -1;
        }
    }
}
