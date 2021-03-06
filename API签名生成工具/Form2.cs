﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API签名生成工具
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "说明";
            //textBox1.Enabled = false;
            textBox1.ReadOnly = true;
            textBox2.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String help = null;
            help += @"使用方式：" + "\r\n";
            help += @"1.本工具用于生成接口sign参数的明文" + "\r\n";
            help += @"2.将HTTP请求中的json内容复制到上文本框" + "\r\n";
            help += @"3.点击[生成]按钮" + "\r\n";
            help += @"4.将生成出的sign参数的明文用于加密" + "\r\n";
            help += @"*.文本框和复选框默认值可通过config文件配置";
            textBox1.Text = help;

            String author = null;
            author += @"tomoya_chen" + "\r\n";
            author += @"上海青客测试部";
            textBox2.Text = author;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://blog.csdn.net/tomoya_chen");
        }

    }
}
