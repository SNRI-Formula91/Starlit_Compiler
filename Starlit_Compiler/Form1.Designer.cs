using System.Configuration;

namespace Starlit_Compiler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox5 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox6 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox7 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox8 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox9 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox10 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox11 = new System.Windows.Forms.CheckedListBox();
            this.workspacePathDialogue = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.commukitPathDialogue = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new CommuFile[] {
            new CommuFile("Haruka", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0101_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTukjyhQg-eGun8ie-kUA5kIqHuJM016rsVLp6OcXfQf-tlt2KJQwONbsS-WjAkPw23vtaikol7_Xvd/pub?gid=1786532299&single=true&output=csv"),
            new CommuFile("Miki", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0102_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTukjyhQg-eGun8ie-kUA5kIqHuJM016rsVLp6OcXfQf-tlt2KJQwONbsS-WjAkPw23vtaikol7_Xvd/pub?gid=1495305424&single=true&output=csv"),
            new CommuFile("Chihaya", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0103_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTukjyhQg-eGun8ie-kUA5kIqHuJM016rsVLp6OcXfQf-tlt2KJQwONbsS-WjAkPw23vtaikol7_Xvd/pub?gid=140432312&single=true&output=csv"),
            new CommuFile("Yayoi", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0104_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTukjyhQg-eGun8ie-kUA5kIqHuJM016rsVLp6OcXfQf-tlt2KJQwONbsS-WjAkPw23vtaikol7_Xvd/pub?gid=670661375&single=true&output=csv"),
            new CommuFile("Yukiho", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0105_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTukjyhQg-eGun8ie-kUA5kIqHuJM016rsVLp6OcXfQf-tlt2KJQwONbsS-WjAkPw23vtaikol7_Xvd/pub?gid=1710270556&single=true&output=csv"),
            new CommuFile("Makoto", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0106_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTukjyhQg-eGun8ie-kUA5kIqHuJM016rsVLp6OcXfQf-tlt2KJQwONbsS-WjAkPw23vtaikol7_Xvd/pub?gid=1668579880&single=true&output=csv"),
            new CommuFile("Mami", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0107_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTukjyhQg-eGun8ie-kUA5kIqHuJM016rsVLp6OcXfQf-tlt2KJQwONbsS-WjAkPw23vtaikol7_Xvd/pub?gid=711449007&single=true&output=csv"),
            new CommuFile("Takane", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0108_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTukjyhQg-eGun8ie-kUA5kIqHuJM016rsVLp6OcXfQf-tlt2KJQwONbsS-WjAkPw23vtaikol7_Xvd/pub?gid=478288512&single=true&output=csv"),
            new CommuFile("Hibiki", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0109_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTukjyhQg-eGun8ie-kUA5kIqHuJM016rsVLp6OcXfQf-tlt2KJQwONbsS-WjAkPw23vtaikol7_Xvd/pub?gid=433586888&single=true&output=csv"),
            new CommuFile("Iori", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0110_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTukjyhQg-eGun8ie-kUA5kIqHuJM016rsVLp6OcXfQf-tlt2KJQwONbsS-WjAkPw23vtaikol7_Xvd/pub?gid=1824079658&single=true&output=csv"),
            new CommuFile("Ami", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0111_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTukjyhQg-eGun8ie-kUA5kIqHuJM016rsVLp6OcXfQf-tlt2KJQwONbsS-WjAkPw23vtaikol7_Xvd/pub?gid=1215962440&single=true&output=csv"),
            new CommuFile("Azusa", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0112_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTukjyhQg-eGun8ie-kUA5kIqHuJM016rsVLp6OcXfQf-tlt2KJQwONbsS-WjAkPw23vtaikol7_Xvd/pub?gid=86159293&single=true&output=csv"),
            new CommuFile("Ritsuko", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0113_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTukjyhQg-eGun8ie-kUA5kIqHuJM016rsVLp6OcXfQf-tlt2KJQwONbsS-WjAkPw23vtaikol7_Xvd/pub?gid=1982571637&single=true&output=csv")
            });
            this.checkedListBox1.Location = new System.Drawing.Point(8, 110);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(117, 199);
            this.checkedListBox1.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new CommuFile[] {
            new CommuFile("Haruka", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0101.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTK9q9FFnBeLdcky8_t501MGA7pYiq6RIpB6hThAonJF9xdlCSif4uQXthhB_ri6cwgTOz98v7RYg-K/pub?gid=1786532299&single=true&output=csv"),
            new CommuFile("Miki", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0102.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTK9q9FFnBeLdcky8_t501MGA7pYiq6RIpB6hThAonJF9xdlCSif4uQXthhB_ri6cwgTOz98v7RYg-K/pub?gid=1495305424&single=true&output=csv"),
            new CommuFile("Chihaya", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0103.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTK9q9FFnBeLdcky8_t501MGA7pYiq6RIpB6hThAonJF9xdlCSif4uQXthhB_ri6cwgTOz98v7RYg-K/pub?gid=140432312&single=true&output=csv"),
            new CommuFile("Yayoi", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0104.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTK9q9FFnBeLdcky8_t501MGA7pYiq6RIpB6hThAonJF9xdlCSif4uQXthhB_ri6cwgTOz98v7RYg-K/pub?gid=670661375&single=true&output=csv"),
            new CommuFile("Yukiho", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0105.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTK9q9FFnBeLdcky8_t501MGA7pYiq6RIpB6hThAonJF9xdlCSif4uQXthhB_ri6cwgTOz98v7RYg-K/pub?gid=1710270556&single=true&output=csv"),
            new CommuFile("Makoto", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0106.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTK9q9FFnBeLdcky8_t501MGA7pYiq6RIpB6hThAonJF9xdlCSif4uQXthhB_ri6cwgTOz98v7RYg-K/pub?gid=1668579880&single=true&output=csv"),
            new CommuFile("Mami", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0107.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTK9q9FFnBeLdcky8_t501MGA7pYiq6RIpB6hThAonJF9xdlCSif4uQXthhB_ri6cwgTOz98v7RYg-K/pub?gid=711449007&single=true&output=csv"),
            new CommuFile("Takane", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0108.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTK9q9FFnBeLdcky8_t501MGA7pYiq6RIpB6hThAonJF9xdlCSif4uQXthhB_ri6cwgTOz98v7RYg-K/pub?gid=478288512&single=true&output=csv"),
            new CommuFile("Hibiki", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0109.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTK9q9FFnBeLdcky8_t501MGA7pYiq6RIpB6hThAonJF9xdlCSif4uQXthhB_ri6cwgTOz98v7RYg-K/pub?gid=433586888&single=true&output=csv"),
            new CommuFile("Iori", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0110.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTK9q9FFnBeLdcky8_t501MGA7pYiq6RIpB6hThAonJF9xdlCSif4uQXthhB_ri6cwgTOz98v7RYg-K/pub?gid=1824079658&single=true&output=csv"),
            new CommuFile("Ami", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0111.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTK9q9FFnBeLdcky8_t501MGA7pYiq6RIpB6hThAonJF9xdlCSif4uQXthhB_ri6cwgTOz98v7RYg-K/pub?gid=1215962440&single=true&output=csv"),
            new CommuFile("Azusa", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0112.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTK9q9FFnBeLdcky8_t501MGA7pYiq6RIpB6hThAonJF9xdlCSif4uQXthhB_ri6cwgTOz98v7RYg-K/pub?gid=86159293&single=true&output=csv"),
            new CommuFile("Ritsuko", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0113.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTK9q9FFnBeLdcky8_t501MGA7pYiq6RIpB6hThAonJF9xdlCSif4uQXthhB_ri6cwgTOz98v7RYg-K/pub?gid=1982571637&single=true&output=csv")
            });
            this.checkedListBox2.Location = new System.Drawing.Point(8, 358);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(117, 199);
            this.checkedListBox2.TabIndex = 1;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new CommuFile[] {
            new CommuFile("Ranko", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0201_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vRO7Vcl7DdOcdwoFqIjtXp2fVuhhvO9vbIxYpgAcP-QQ11kW3ssq9eFiyfMG-Z-47VkTwNOVXhQr2ca/pub?gid=2002020037&single=true&output=csv"),
            new CommuFile("Anzu", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0202_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vRO7Vcl7DdOcdwoFqIjtXp2fVuhhvO9vbIxYpgAcP-QQ11kW3ssq9eFiyfMG-Z-47VkTwNOVXhQr2ca/pub?gid=1616013145&single=true&output=csv"),
            new CommuFile("Mika", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0203_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vRO7Vcl7DdOcdwoFqIjtXp2fVuhhvO9vbIxYpgAcP-QQ11kW3ssq9eFiyfMG-Z-47VkTwNOVXhQr2ca/pub?gid=2005612050&single=true&output=csv"),
            new CommuFile("Kirari", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0204_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vRO7Vcl7DdOcdwoFqIjtXp2fVuhhvO9vbIxYpgAcP-QQ11kW3ssq9eFiyfMG-Z-47VkTwNOVXhQr2ca/pub?gid=1258565376&single=true&output=csv"),
            new CommuFile("Nana", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0205_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vRO7Vcl7DdOcdwoFqIjtXp2fVuhhvO9vbIxYpgAcP-QQ11kW3ssq9eFiyfMG-Z-47VkTwNOVXhQr2ca/pub?gid=298474984&single=true&output=csv"),
            new CommuFile("Kaede", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0206_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vRO7Vcl7DdOcdwoFqIjtXp2fVuhhvO9vbIxYpgAcP-QQ11kW3ssq9eFiyfMG-Z-47VkTwNOVXhQr2ca/pub?gid=1840114057&single=true&output=csv"),
            new CommuFile("Mirai", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0301_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vRO7Vcl7DdOcdwoFqIjtXp2fVuhhvO9vbIxYpgAcP-QQ11kW3ssq9eFiyfMG-Z-47VkTwNOVXhQr2ca/pub?gid=965365194&single=true&output=csv"),
            new CommuFile("Shizuka", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0302_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vRO7Vcl7DdOcdwoFqIjtXp2fVuhhvO9vbIxYpgAcP-QQ11kW3ssq9eFiyfMG-Z-47VkTwNOVXhQr2ca/pub?gid=1030065350&single=true&output=csv"),
            new CommuFile("Tsubasa", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0303_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vRO7Vcl7DdOcdwoFqIjtXp2fVuhhvO9vbIxYpgAcP-QQ11kW3ssq9eFiyfMG-Z-47VkTwNOVXhQr2ca/pub?gid=1080839728&single=true&output=csv"),
            new CommuFile("Tsumugi", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0304_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vRO7Vcl7DdOcdwoFqIjtXp2fVuhhvO9vbIxYpgAcP-QQ11kW3ssq9eFiyfMG-Z-47VkTwNOVXhQr2ca/pub?gid=699579573&single=true&output=csv"),
            new CommuFile("Kaori", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0305_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vRO7Vcl7DdOcdwoFqIjtXp2fVuhhvO9vbIxYpgAcP-QQ11kW3ssq9eFiyfMG-Z-47VkTwNOVXhQr2ca/pub?gid=686826671&single=true&output=csv"),
            new CommuFile("Kotoha", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0306_A.csv",
            "NULL")
            });
            this.checkedListBox3.Location = new System.Drawing.Point(140, 358);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(117, 199);
            this.checkedListBox3.TabIndex = 3;
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Items.AddRange(new CommuFile[] {
            new CommuFile("Ranko", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0201.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTrZhYrpscCXXC00Gg5n-cHDHfqrpOVEUv7laHoF58QylGdFJW9lwgwHpgOcX08i6idUk0gn28A1oZt/pub?gid=2002020037&single=true&output=csv"),
            new CommuFile("Anzu", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0202.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTrZhYrpscCXXC00Gg5n-cHDHfqrpOVEUv7laHoF58QylGdFJW9lwgwHpgOcX08i6idUk0gn28A1oZt/pub?gid=1616013145&single=true&output=csv"),
            new CommuFile("Mika", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0203.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTrZhYrpscCXXC00Gg5n-cHDHfqrpOVEUv7laHoF58QylGdFJW9lwgwHpgOcX08i6idUk0gn28A1oZt/pub?gid=2005612050&single=true&output=csv"),
            new CommuFile("Kirari", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0204.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTrZhYrpscCXXC00Gg5n-cHDHfqrpOVEUv7laHoF58QylGdFJW9lwgwHpgOcX08i6idUk0gn28A1oZt/pub?gid=1258565376&single=true&output=csv"),
            new CommuFile("Nana", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0205.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTrZhYrpscCXXC00Gg5n-cHDHfqrpOVEUv7laHoF58QylGdFJW9lwgwHpgOcX08i6idUk0gn28A1oZt/pub?gid=298474984&single=true&output=csv"),
            new CommuFile("Kaede", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0206.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTrZhYrpscCXXC00Gg5n-cHDHfqrpOVEUv7laHoF58QylGdFJW9lwgwHpgOcX08i6idUk0gn28A1oZt/pub?gid=1278012534&single=true&output=csv"),
            new CommuFile("Mirai", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0301.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTrZhYrpscCXXC00Gg5n-cHDHfqrpOVEUv7laHoF58QylGdFJW9lwgwHpgOcX08i6idUk0gn28A1oZt/pub?gid=965365194&single=true&output=csv"),
            new CommuFile("Shizuka", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0302.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTrZhYrpscCXXC00Gg5n-cHDHfqrpOVEUv7laHoF58QylGdFJW9lwgwHpgOcX08i6idUk0gn28A1oZt/pub?gid=1030065350&single=true&output=csv"),
            new CommuFile("Tsubasa", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0303.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTrZhYrpscCXXC00Gg5n-cHDHfqrpOVEUv7laHoF58QylGdFJW9lwgwHpgOcX08i6idUk0gn28A1oZt/pub?gid=1080839728&single=true&output=csv"),
            new CommuFile("Tsumugi", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0304.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTrZhYrpscCXXC00Gg5n-cHDHfqrpOVEUv7laHoF58QylGdFJW9lwgwHpgOcX08i6idUk0gn28A1oZt/pub?gid=699579573&single=true&output=csv"),
            new CommuFile("Kaori", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0305.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTrZhYrpscCXXC00Gg5n-cHDHfqrpOVEUv7laHoF58QylGdFJW9lwgwHpgOcX08i6idUk0gn28A1oZt/pub?gid=686826671&single=true&output=csv"),
            new CommuFile("Kotoha", "\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0306.csv",
            "NULL")
            });
            this.checkedListBox4.Location = new System.Drawing.Point(140, 110);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(117, 199);
            this.checkedListBox4.TabIndex = 2;
            // 
            // checkedListBox5
            // 
            this.checkedListBox5.FormattingEnabled = true;
            this.checkedListBox5.Items.AddRange(new CommuFile[] {
            new CommuFile("Tenka","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0401_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTjeJovcd8xvdBv-UwsSKNzNgMD0-DuBCIchzjp2tq0zWSdn09FpNLPkG5nVZ0z6-R-wkjHSynGIgue/pub?gid=2002020037&single=true&output=csv"),
            new CommuFile("Sakuya","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0402_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTjeJovcd8xvdBv-UwsSKNzNgMD0-DuBCIchzjp2tq0zWSdn09FpNLPkG5nVZ0z6-R-wkjHSynGIgue/pub?gid=1616013145&single=true&output=csv"),
            new CommuFile("Kaho","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0403_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTjeJovcd8xvdBv-UwsSKNzNgMD0-DuBCIchzjp2tq0zWSdn09FpNLPkG5nVZ0z6-R-wkjHSynGIgue/pub?gid=2005612050&single=true&output=csv"),
            new CommuFile("Amana","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0404_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTjeJovcd8xvdBv-UwsSKNzNgMD0-DuBCIchzjp2tq0zWSdn09FpNLPkG5nVZ0z6-R-wkjHSynGIgue/pub?gid=1258565376&single=true&output=csv"),
            new CommuFile("Rinze","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0405_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTjeJovcd8xvdBv-UwsSKNzNgMD0-DuBCIchzjp2tq0zWSdn09FpNLPkG5nVZ0z6-R-wkjHSynGIgue/pub?gid=298474984&single=true&output=csv"),
            new CommuFile("Mamimi","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0406_A.csv",
            "NULL"),
            new CommuFile("Leon","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0501_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTjeJovcd8xvdBv-UwsSKNzNgMD0-DuBCIchzjp2tq0zWSdn09FpNLPkG5nVZ0z6-R-wkjHSynGIgue/pub?gid=965365194&single=true&output=csv"),
            new CommuFile("Shika","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0502_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTjeJovcd8xvdBv-UwsSKNzNgMD0-DuBCIchzjp2tq0zWSdn09FpNLPkG5nVZ0z6-R-wkjHSynGIgue/pub?gid=1030065350&single=true&output=csv"),
            new CommuFile("Kohaku","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0601_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTjeJovcd8xvdBv-UwsSKNzNgMD0-DuBCIchzjp2tq0zWSdn09FpNLPkG5nVZ0z6-R-wkjHSynGIgue/pub?gid=1080839728&single=true&output=csv"),
            new CommuFile("Aya","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_0602_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTjeJovcd8xvdBv-UwsSKNzNgMD0-DuBCIchzjp2tq0zWSdn09FpNLPkG5nVZ0z6-R-wkjHSynGIgue/pub?gid=699579573&single=true&output=csv")
            });
            this.checkedListBox5.Location = new System.Drawing.Point(272, 358);
            this.checkedListBox5.Name = "checkedListBox5";
            this.checkedListBox5.Size = new System.Drawing.Size(117, 199);
            this.checkedListBox5.TabIndex = 5;
            // 
            // checkedListBox6
            // 
            this.checkedListBox6.FormattingEnabled = true;
            this.checkedListBox6.Items.AddRange(new CommuFile[] {
            new CommuFile("Tenka","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0401.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQuktY8WZeM6J736p6MGY7_OGejXvqb3tfHSRBzBxt_I3hjcrOh5pW1V632CV2QjhTTTTPqTJ73Ts0Q/pub?gid=2002020037&single=true&output=csv"),
            new CommuFile("Sakuya","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0402.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQuktY8WZeM6J736p6MGY7_OGejXvqb3tfHSRBzBxt_I3hjcrOh5pW1V632CV2QjhTTTTPqTJ73Ts0Q/pub?gid=1616013145&single=true&output=csv"),
            new CommuFile("Kaho","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0403.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQuktY8WZeM6J736p6MGY7_OGejXvqb3tfHSRBzBxt_I3hjcrOh5pW1V632CV2QjhTTTTPqTJ73Ts0Q/pub?gid=2005612050&single=true&output=csv"),
            new CommuFile("Amana","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0404.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQuktY8WZeM6J736p6MGY7_OGejXvqb3tfHSRBzBxt_I3hjcrOh5pW1V632CV2QjhTTTTPqTJ73Ts0Q/pub?gid=1258565376&single=true&output=csv"),
            new CommuFile("Rinze","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0405.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQuktY8WZeM6J736p6MGY7_OGejXvqb3tfHSRBzBxt_I3hjcrOh5pW1V632CV2QjhTTTTPqTJ73Ts0Q/pub?gid=298474984&single=true&output=csv"),
            new CommuFile("Mamimi","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0406.csv",
            "NULL"),
            new CommuFile("Leon","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0501.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQuktY8WZeM6J736p6MGY7_OGejXvqb3tfHSRBzBxt_I3hjcrOh5pW1V632CV2QjhTTTTPqTJ73Ts0Q/pub?gid=965365194&single=true&output=csv"),
            new CommuFile("Shika","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0502.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQuktY8WZeM6J736p6MGY7_OGejXvqb3tfHSRBzBxt_I3hjcrOh5pW1V632CV2QjhTTTTPqTJ73Ts0Q/pub?gid=1030065350&single=true&output=csv"),
            new CommuFile("Kohaku","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0601.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQuktY8WZeM6J736p6MGY7_OGejXvqb3tfHSRBzBxt_I3hjcrOh5pW1V632CV2QjhTTTTPqTJ73Ts0Q/pub?gid=1080839728&single=true&output=csv"),
            new CommuFile("Aya","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idol_contact_chr_0602.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQuktY8WZeM6J736p6MGY7_OGejXvqb3tfHSRBzBxt_I3hjcrOh5pW1V632CV2QjhTTTTPqTJ73Ts0Q/pub?gid=699579573&single=true&output=csv")});
            this.checkedListBox6.Location = new System.Drawing.Point(272, 110);
            this.checkedListBox6.Name = "checkedListBox6";
            this.checkedListBox6.Size = new System.Drawing.Size(117, 199);
            this.checkedListBox6.TabIndex = 4;
            // 
            // checkedListBox7
            // 
            this.checkedListBox7.ColumnWidth = 3;
            this.checkedListBox7.FormattingEnabled = true;
            this.checkedListBox7.Items.AddRange(new CommuFile[] {
            new CommuFile("March","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Main\\CML_main_0003_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTVArsn6hvhHm5blXl5xFIF-eiFX6e0mKKdOxJQEHYBhskUPrNWvKTJG6B1UHNI1tC5RM0rI_muIzt4/pub?gid=299988709&single=true&output=csv"),
            new CommuFile("April","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Main\\CML_main_0004_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTVArsn6hvhHm5blXl5xFIF-eiFX6e0mKKdOxJQEHYBhskUPrNWvKTJG6B1UHNI1tC5RM0rI_muIzt4/pub?gid=1571659376&single=true&output=csv"),
            new CommuFile("May","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Main\\CML_main_0005_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTVArsn6hvhHm5blXl5xFIF-eiFX6e0mKKdOxJQEHYBhskUPrNWvKTJG6B1UHNI1tC5RM0rI_muIzt4/pub?gid=1732343537&single=true&output=csv"),
            new CommuFile("June","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Main\\CML_main_0006_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTVArsn6hvhHm5blXl5xFIF-eiFX6e0mKKdOxJQEHYBhskUPrNWvKTJG6B1UHNI1tC5RM0rI_muIzt4/pub?gid=436301072&single=true&output=csv"),
            new CommuFile("July","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Main\\CML_main_0007_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTVArsn6hvhHm5blXl5xFIF-eiFX6e0mKKdOxJQEHYBhskUPrNWvKTJG6B1UHNI1tC5RM0rI_muIzt4/pub?gid=1441462413&single=true&output=csv"),
            new CommuFile("August","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Main\\CML_main_0008_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTVArsn6hvhHm5blXl5xFIF-eiFX6e0mKKdOxJQEHYBhskUPrNWvKTJG6B1UHNI1tC5RM0rI_muIzt4/pub?gid=1259272234&single=true&output=csv"),
            new CommuFile("September","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Main\\CML_main_0009_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTVArsn6hvhHm5blXl5xFIF-eiFX6e0mKKdOxJQEHYBhskUPrNWvKTJG6B1UHNI1tC5RM0rI_muIzt4/pub?gid=1287451924&single=true&output=csv"),
            new CommuFile("October","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Main\\CML_main_0010_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTVArsn6hvhHm5blXl5xFIF-eiFX6e0mKKdOxJQEHYBhskUPrNWvKTJG6B1UHNI1tC5RM0rI_muIzt4/pub?gid=1212183902&single=true&output=csv"),
            new CommuFile("November","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Main\\CML_main_0011_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTVArsn6hvhHm5blXl5xFIF-eiFX6e0mKKdOxJQEHYBhskUPrNWvKTJG6B1UHNI1tC5RM0rI_muIzt4/pub?gid=196009671&single=true&output=csv"),
            new CommuFile("December","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Main\\CML_main_0012_A.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTVArsn6hvhHm5blXl5xFIF-eiFX6e0mKKdOxJQEHYBhskUPrNWvKTJG6B1UHNI1tC5RM0rI_muIzt4/pub?gid=1863022054&single=true&output=csv"),
            new CommuFile("December (EX)","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Main\\CML_main_0012_END.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTVArsn6hvhHm5blXl5xFIF-eiFX6e0mKKdOxJQEHYBhskUPrNWvKTJG6B1UHNI1tC5RM0rI_muIzt4/pub?gid=1217159057&single=true&output=csv")
            });
            this.checkedListBox7.Location = new System.Drawing.Point(405, 110);
            this.checkedListBox7.Name = "checkedListBox7";
            this.checkedListBox7.Size = new System.Drawing.Size(117, 199);
            this.checkedListBox7.TabIndex = 6;
            // 
            // checkedListBox8
            // 
            this.checkedListBox8.FormattingEnabled = true;
            this.checkedListBox8.Items.AddRange(new CommuFile[] {
            new CommuFile("Kazuo","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\NPC\\CML_ConnectionNpc_1208.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQ_s0JbplOyPl2q2UHFjxEw6MoqIIZRh-SW80FsMCr0DSVhPci3FEOM3xvJXXek2_MCDZv1CLH3SPHc/pub?gid=1182610682&single=true&output=csv"),
            new CommuFile("Yasuna","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\NPC\\CML_ConnectionNpc_1209.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQ_s0JbplOyPl2q2UHFjxEw6MoqIIZRh-SW80FsMCr0DSVhPci3FEOM3xvJXXek2_MCDZv1CLH3SPHc/pub?gid=944332691&single=true&output=csv"),
            new CommuFile("Teruya","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\NPC\\CML_ConnectionNpc_1210.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQ_s0JbplOyPl2q2UHFjxEw6MoqIIZRh-SW80FsMCr0DSVhPci3FEOM3xvJXXek2_MCDZv1CLH3SPHc/pub?gid=990463863&single=true&output=csv"),
            new CommuFile("Taizo","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\NPC\\CML_ConnectionNpc_1211.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQ_s0JbplOyPl2q2UHFjxEw6MoqIIZRh-SW80FsMCr0DSVhPci3FEOM3xvJXXek2_MCDZv1CLH3SPHc/pub?gid=734603640&single=true&output=csv"),
            new CommuFile("Kawara","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\NPC\\CML_ConnectionNpc_1213.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQ_s0JbplOyPl2q2UHFjxEw6MoqIIZRh-SW80FsMCr0DSVhPci3FEOM3xvJXXek2_MCDZv1CLH3SPHc/pub?gid=1741911821&single=true&output=csv"),
            new CommuFile("Shop NPCs","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Shop\\CML_shop_000.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vSpF_wvQfJbLI7R_LpZeryceGVFDkPEqDP0VEaHLZU2rqKol8zsXtUP2MRfpzpKqJ4jByOi9iqNiHQC/pub?gid=1135963320&single=true&output=csv"),
            new CommuFile("Diamant 1","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Shop\\Diamant\\CML_Diamant_0000.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vSpF_wvQfJbLI7R_LpZeryceGVFDkPEqDP0VEaHLZU2rqKol8zsXtUP2MRfpzpKqJ4jByOi9iqNiHQC/pub?gid=1416049310&single=true&output=csv"),
            new CommuFile("Diamant 2","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Shop\\Diamant\\CML_Diamant_0100.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vSpF_wvQfJbLI7R_LpZeryceGVFDkPEqDP0VEaHLZU2rqKol8zsXtUP2MRfpzpKqJ4jByOi9iqNiHQC/pub?gid=421014842&single=true&output=csv"),
            new CommuFile("Diamant 3","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Shop\\Diamant\\CML_Diamant_0300.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vSpF_wvQfJbLI7R_LpZeryceGVFDkPEqDP0VEaHLZU2rqKol8zsXtUP2MRfpzpKqJ4jByOi9iqNiHQC/pub?gid=1794569505&single=true&output=csv"),
            new CommuFile("Names List","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Name\\CML_Name.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vSpF_wvQfJbLI7R_LpZeryceGVFDkPEqDP0VEaHLZU2rqKol8zsXtUP2MRfpzpKqJ4jByOi9iqNiHQC/pub?gid=923395183&single=true&output=csv")
            });
            this.checkedListBox8.Location = new System.Drawing.Point(405, 358);
            this.checkedListBox8.Name = "checkedListBox8";
            this.checkedListBox8.Size = new System.Drawing.Size(117, 199);
            this.checkedListBox8.TabIndex = 7;
            // 
            // checkedListBox9
            // 
            this.checkedListBox9.FormattingEnabled = true;
            this.checkedListBox9.Items.AddRange(new CommuFile[] {
            new CommuFile("Birthdays","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_birthday.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vR1MUhMRIB5P2QdHKqCWrYjf1jZovtVU5MJEBt3xrpkd8pQEIOtIr37dBU1rodcAgvgdOemsJ0Pxstz/pub?gid=1319429842&single=true&output=csv"),
            new CommuFile("Pre/Post Work","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Morning\\CML_producer_000.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vR1MUhMRIB5P2QdHKqCWrYjf1jZovtVU5MJEBt3xrpkd8pQEIOtIr37dBU1rodcAgvgdOemsJ0Pxstz/pub?gid=1525630461&single=true&output=csv"),
            new CommuFile("Work","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\GameOver\\CML_YAKU.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vR1MUhMRIB5P2QdHKqCWrYjf1jZovtVU5MJEBt3xrpkd8pQEIOtIr37dBU1rodcAgvgdOemsJ0Pxstz/pub?gid=1595042447&single=true&output=csv"),
            new CommuFile("Work 2","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Order\\CML_officechr_message.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vR1MUhMRIB5P2QdHKqCWrYjf1jZovtVU5MJEBt3xrpkd8pQEIOtIr37dBU1rodcAgvgdOemsJ0Pxstz/pub?gid=1248128989&single=true&output=csv"),
            new CommuFile("New Outfits","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Costume\\CML_idolchr_costume.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vR1MUhMRIB5P2QdHKqCWrYjf1jZovtVU5MJEBt3xrpkd8pQEIOtIr37dBU1rodcAgvgdOemsJ0Pxstz/pub?gid=85613363&single=true&output=csv"),
            new CommuFile("Monthly Stage","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Stage\\CML_Stage_Select.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vR1MUhMRIB5P2QdHKqCWrYjf1jZovtVU5MJEBt3xrpkd8pQEIOtIr37dBU1rodcAgvgdOemsJ0Pxstz/pub?gid=1561180137&single=true&output=csv"),
            new CommuFile("Climax Challenge","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Stage\\CML_idol_climax_challenge.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vR1MUhMRIB5P2QdHKqCWrYjf1jZovtVU5MJEBt3xrpkd8pQEIOtIr37dBU1rodcAgvgdOemsJ0Pxstz/pub?gid=5024484&single=true&output=csv"),
            new CommuFile("Crossover Commus","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Idol\\CML_idolchr_crossover.csv", 
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vRC17hk6elZWNgFZaqGw8Vw13aMujo38Fx0IkvQB6vtKypjkZkahYX3YeF7DbZ2j2RPcerYaT0YKnkM/pub?gid=1518693967&single=true&output=csv"),
            new CommuFile("Unity Commus","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Unity\\CML_idolchr_danketu.csv", 
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vRC17hk6elZWNgFZaqGw8Vw13aMujo38Fx0IkvQB6vtKypjkZkahYX3YeF7DbZ2j2RPcerYaT0YKnkM/pub?gid=1182610682&single=true&output=csv")
            });
            this.checkedListBox9.Location = new System.Drawing.Point(538, 110);
            this.checkedListBox9.Name = "checkedListBox9";
            this.checkedListBox9.Size = new System.Drawing.Size(117, 199);
            this.checkedListBox9.TabIndex = 8;
            // 
            // checkedListBox10
            // 
            this.checkedListBox10.FormattingEnabled = true;
            this.checkedListBox10.Items.AddRange(new CommuFile[] {
            new CommuFile("All Bad Endings","ALL_BAD_ENDINGS","NONE"),
            new CommuFile("Tutorial 1","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Tutorial\\FreeTime\\CML_Tutorial_02_0000_00.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTr7QO2AiiMvCSRB_q-NKJhXKFuln1ZMlT-lyy1bWrSCTvWwOpB5wODI1-9BVl3sFyrOM98sTQBgGo6/pub?gid=1948933537&single=true&output=csv"),
            new CommuFile("Tutorial 2","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Tutorial\\FreeTime\\CML_Tutorial_02_0001_00.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTr7QO2AiiMvCSRB_q-NKJhXKFuln1ZMlT-lyy1bWrSCTvWwOpB5wODI1-9BVl3sFyrOM98sTQBgGo6/pub?gid=427499634&single=true&output=csv"),
            new CommuFile("Tutorial 3","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Tutorial\\FreeTime\\CML_Tutorial_02_0002_00.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTr7QO2AiiMvCSRB_q-NKJhXKFuln1ZMlT-lyy1bWrSCTvWwOpB5wODI1-9BVl3sFyrOM98sTQBgGo6/pub?gid=554363070&single=true&output=csv"),
            new CommuFile("Tutorial 4","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Tutorial\\FreeTime\\CML_Tutorial_02_0003_00.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTr7QO2AiiMvCSRB_q-NKJhXKFuln1ZMlT-lyy1bWrSCTvWwOpB5wODI1-9BVl3sFyrOM98sTQBgGo6/pub?gid=399129534&single=true&output=csv"),
            new CommuFile("Tutorial 5","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Tutorial\\FreeTime\\CML_Tutorial_02_0003_10.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTr7QO2AiiMvCSRB_q-NKJhXKFuln1ZMlT-lyy1bWrSCTvWwOpB5wODI1-9BVl3sFyrOM98sTQBgGo6/pub?gid=1470668965&single=true&output=csv"),
            new CommuFile("Tutorial 6","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Tutorial\\FreeTime\\CML_Tutorial_02_0004_00.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTr7QO2AiiMvCSRB_q-NKJhXKFuln1ZMlT-lyy1bWrSCTvWwOpB5wODI1-9BVl3sFyrOM98sTQBgGo6/pub?gid=585801802&single=true&output=csv"),
            new CommuFile("Tutorial 7","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Tutorial\\FreeTime\\CML_Tutorial_02_0005_00.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTr7QO2AiiMvCSRB_q-NKJhXKFuln1ZMlT-lyy1bWrSCTvWwOpB5wODI1-9BVl3sFyrOM98sTQBgGo6/pub?gid=918935330&single=true&output=csv"),
            new CommuFile("Tutorial 8","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Tutorial\\FreeTime\\CML_Tutorial_02_0006_00.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTr7QO2AiiMvCSRB_q-NKJhXKFuln1ZMlT-lyy1bWrSCTvWwOpB5wODI1-9BVl3sFyrOM98sTQBgGo6/pub?gid=2103795357&single=true&output=csv"),
            new CommuFile("Tutorial 9","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Tutorial\\FreeTime\\CML_Tutorial_02_0007_00.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTr7QO2AiiMvCSRB_q-NKJhXKFuln1ZMlT-lyy1bWrSCTvWwOpB5wODI1-9BVl3sFyrOM98sTQBgGo6/pub?gid=713266493&single=true&output=csv"),
            new CommuFile("Tutorial 10","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Tutorial\\FreeTime\\CML_Tutorial_02_0008_00.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTr7QO2AiiMvCSRB_q-NKJhXKFuln1ZMlT-lyy1bWrSCTvWwOpB5wODI1-9BVl3sFyrOM98sTQBgGo6/pub?gid=849983027&single=true&output=csv"),
            new CommuFile("Tutorial 11","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Tutorial\\FreeTime\\CML_Tutorial_02_0009_00.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vTr7QO2AiiMvCSRB_q-NKJhXKFuln1ZMlT-lyy1bWrSCTvWwOpB5wODI1-9BVl3sFyrOM98sTQBgGo6/pub?gid=10963591&single=true&output=csv")
            });
            this.checkedListBox10.Location = new System.Drawing.Point(538, 358);
            this.checkedListBox10.Name = "checkedListBox10";
            this.checkedListBox10.Size = new System.Drawing.Size(117, 199);
            this.checkedListBox10.TabIndex = 9;
            // 
            // checkedListBox11
            // 
            this.checkedListBox11.FormattingEnabled = true;
            this.checkedListBox11.Items.AddRange(new CommuFile[] {
            new CommuFile("Secret Message","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Append\\CML_Limited.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQCMwuAQayvXKjPOXytKGQp7aWh5RWpfv_5PIW3UlNsPzOHiOglHzxGyixR81VYiy_Y-tcOFg_PdTmy/pub?gid=299988709&single=true&output=csv"),
            new CommuFile("Smile Festa","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Append\\CML_dlc_Side15ANV.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQCMwuAQayvXKjPOXytKGQp7aWh5RWpfv_5PIW3UlNsPzOHiOglHzxGyixR81VYiy_Y-tcOFg_PdTmy/pub?gid=404755722&single=true&output=csv"),
            new CommuFile("Luminous Azul","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Append\\CML_dlc_Side_cool.csv",
            "https://docs.google.com/spreadsheets/d/e/2PACX-1vQCMwuAQayvXKjPOXytKGQp7aWh5RWpfv_5PIW3UlNsPzOHiOglHzxGyixR81VYiy_Y-tcOFg_PdTmy/pub?gid=450632735&single=true&output=csv"),
            new CommuFile("Luminous Rufus","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Append\\CML_dlc_Side_cute.csv",
            "NULL"),
            new CommuFile("Luminous Giallo","\\pakchunk99-EngPatch\\StarlitSeason\\Content\\Commu\\Localize\\Append\\CML_dlc_Side_passion.csv",
            "NULL"),
            new CommuFile("DLC6", "NULL", "NULL"),
            new CommuFile("Japan 47", "NULL", "NULL")
            });
            this.checkedListBox11.Location = new System.Drawing.Point(671, 110);
            this.checkedListBox11.Name = "checkedListBox11";
            this.checkedListBox11.Size = new System.Drawing.Size(117, 199);
            this.checkedListBox11.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(514, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(514, 20);
            this.textBox2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 13;
            this.button1.TabStop = false;
            this.button1.Text = "Workspace Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Commu-kit Path";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(671, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 24);
            this.button3.TabIndex = 15;
            this.button3.Text = "Import All Commus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(671, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 24);
            this.button4.TabIndex = 16;
            this.button4.Text = "Import Selected Commus";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(671, 418);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Only Update UI";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(140, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(117, 13);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "CG/ML Commus";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(8, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(117, 13);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "765AS Commus";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(272, 68);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(117, 13);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "SC/Other Commus";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(405, 68);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(117, 13);
            this.textBox6.TabIndex = 22;
            this.textBox6.Text = "Main Story";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Window;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(538, 68);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(117, 13);
            this.textBox7.TabIndex = 23;
            this.textBox7.Text = "Game Events";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Window;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(671, 68);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(117, 13);
            this.textBox8.TabIndex = 24;
            this.textBox8.Text = "DLC Story";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Window;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(8, 317);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(117, 13);
            this.textBox9.TabIndex = 25;
            this.textBox9.Text = "765AS Work+Events";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Window;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(140, 317);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(117, 13);
            this.textBox10.TabIndex = 26;
            this.textBox10.Text = "CG/ML Work+Events";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Window;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(272, 317);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(117, 13);
            this.textBox11.TabIndex = 27;
            this.textBox11.Text = "SC/Other Work+Events";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Window;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(405, 317);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(117, 13);
            this.textBox12.TabIndex = 28;
            this.textBox12.Text = "NPC Dialogue+Commus";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Window;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Location = new System.Drawing.Point(538, 317);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(117, 13);
            this.textBox13.TabIndex = 29;
            this.textBox13.Text = "Other";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(27, 83);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 41;
            this.button6.Text = "Select All";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(160, 83);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 42;
            this.button7.Text = "Select All";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(292, 83);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 43;
            this.button8.Text = "Select All";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(421, 83);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 44;
            this.button9.Text = "Select All";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(558, 83);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 45;
            this.button10.Text = "Select All";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(689, 83);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 46;
            this.button11.Text = "Select All";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(27, 332);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 47;
            this.button12.Text = "Select All";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(160, 332);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 48;
            this.button13.Text = "Select All";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(292, 332);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 49;
            this.button14.Text = "Select All";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(421, 332);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 50;
            this.button15.Text = "Select All";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(558, 332);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 51;
            this.button16.Text = "Select All";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(797, 565);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox11);
            this.Controls.Add(this.checkedListBox10);
            this.Controls.Add(this.checkedListBox9);
            this.Controls.Add(this.checkedListBox8);
            this.Controls.Add(this.checkedListBox7);
            this.Controls.Add(this.checkedListBox5);
            this.Controls.Add(this.checkedListBox6);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.checkedListBox4);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Starlit Compiler";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox4;
        private System.Windows.Forms.CheckedListBox checkedListBox5;
        private System.Windows.Forms.CheckedListBox checkedListBox6;
        private System.Windows.Forms.CheckedListBox checkedListBox7;
        private System.Windows.Forms.CheckedListBox checkedListBox8;
        private System.Windows.Forms.CheckedListBox checkedListBox9;
        private System.Windows.Forms.CheckedListBox checkedListBox10;
        private System.Windows.Forms.CheckedListBox checkedListBox11;
        private System.Windows.Forms.FolderBrowserDialog workspacePathDialogue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.FolderBrowserDialog commukitPathDialogue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

