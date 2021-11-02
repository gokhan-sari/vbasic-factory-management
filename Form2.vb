Imports System.Data
Imports System.Data.OleDb
Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 475
        Me.CenterToScreen()
    End Sub

    Private Sub Form2_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub menu1_1_Click(sender As System.Object, e As System.EventArgs) Handles menu1_1.Click
        Panel1.Visible = True
        Panel1.Location = New Point(0, 25)
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False

        Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
        baglanti.Open()
        Dim sorgu As New OleDb.OleDbCommand("select * from urunstok", baglanti)
        Dim tablo = New DataTable()
        tablo.Load(sorgu.ExecuteReader())
        DataGridView1.DataSource = tablo
        Dim getir As OleDb.OleDbDataReader = sorgu.ExecuteReader()
        ComboBox1.Items.Clear()
        ComboBox1.Text = "Ürün Adı"
        ComboBox2.Items.Clear()
        ComboBox2.Text = "Ürün Kodu"
        While getir.Read()
            ComboBox1.Items.Add(getir("urn_adi"))
            ComboBox2.Items.Add(getir("urn_kodu"))
        End While
        baglanti.Close()
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        NumericUpDown1.Visible = False
        Button2.Visible = False
        Button2.Enabled = False

    End Sub

    Private Sub menu1_2_Click(sender As System.Object, e As System.EventArgs) Handles menu1_2.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel2.Location = New Point(0, 25)
        Panel3.Visible = False
        Panel4.Visible = False

        Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
        baglanti.Open()
        Dim sorgu As New OleDb.OleDbCommand("select * from hammadde", baglanti)
        Dim tablo = New DataTable()
        tablo.Load(sorgu.ExecuteReader())
        DataGridView2.DataSource = tablo
        Dim getir As OleDb.OleDbDataReader = sorgu.ExecuteReader()
        ComboBox3.Items.Clear()
        ComboBox3.Text = "Hammadde Adı"
        ComboBox4.Items.Clear()
        ComboBox4.Text = "Hammadde Kodu"
        While getir.Read()
            ComboBox3.Items.Add(getir("ham_adi"))
            ComboBox4.Items.Add(getir("ham_kodu"))
        End While
        baglanti.Close()
        TextBox1.Text = ""
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        Label22.Visible = False
        TextBox1.Visible = False
        Button4.Visible = False
        Button4.Enabled = False
    End Sub

    Private Sub menu2_Click(sender As System.Object, e As System.EventArgs) Handles menu2.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel3.Location = New Point(0, 25)
        Panel4.Visible = False

        Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
        baglanti.Open()
        Dim sorgu1 As New OleDb.OleDbCommand("select ham_kodu,ham_adi,ham_miktari from hammadde", baglanti)
        Dim tablo1 = New DataTable()
        tablo1.Load(sorgu1.ExecuteReader())
        DataGridView3.DataSource = tablo1
        Dim sorgu2 As New OleDb.OleDbCommand("select urn_kodu,urn_adi,urn_miktari from urunstok", baglanti)
        Dim tablo2 = New DataTable()
        tablo2.Load(sorgu2.ExecuteReader())
        DataGridView4.DataSource = tablo2

        Dim getir As OleDb.OleDbDataReader = sorgu2.ExecuteReader()
        ComboBox5.Items.Clear()
        ComboBox5.Text = "Seçiniz"
        While getir.Read()
            ComboBox5.Items.Add(getir("urn_kodu") + " | " + getir("urn_adi"))
        End While
        baglanti.Close()
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        NumericUpDown2.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        NumericUpDown2.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button9.Enabled = False
    End Sub

    Private Sub menu3_Click(sender As System.Object, e As System.EventArgs) Handles menu3.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
        Panel4.Location = New Point(0, 25)

        Label41.Text = Form1.goad

        Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
        baglanti.Open()
        Dim sorgu1 As New OleDb.OleDbCommand("select * from kullanici where usr_kadi='" + Label41.Text + "'", baglanti)
        Dim getir As OleDb.OleDbDataReader = sorgu1.ExecuteReader()

        While getir.Read()
            Label39.Text = Convert.ToString(getir("usr_adi"))
            Label40.Text = Convert.ToString(getir("usr_tcno"))
            TextBox2.Text = Convert.ToString(getir("usr_sifre"))
            Label42.Text = Convert.ToString(getir("usr_sifre"))
            TextBox3.Text = Convert.ToString(getir("usr_sirket_adi"))
            Label43.Text = Convert.ToString(getir("usr_sirket_adi"))
            TextBox4.Text = Convert.ToString(getir("usr_telno"))
            Label44.Text = Convert.ToString(getir("usr_telno"))
            TextBox5.Text = Convert.ToString(getir("usr_sirket_adresi"))
            Label45.Text = Convert.ToString(getir("usr_sirket_adresi"))
        End While

        Button10.Enabled = False

        baglanti.Close()

    End Sub

    Private Sub menu4_Click(sender As System.Object, e As System.EventArgs) Handles menu4.Click
        Form3.Show()
    End Sub

    Private Sub menu5_Click(sender As System.Object, e As System.EventArgs) Handles menu5.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
        baglanti.Open()
        Dim sorgu As New OleDb.OleDbCommand("select * from urunstok", baglanti)
        Dim tablo = New DataTable()
        tablo.Load(sorgu.ExecuteReader())
        DataGridView1.DataSource = tablo
        baglanti.Close()
        ComboBox1.Text = "Ürün Adı"
        ComboBox2.Text = "Ürün Kodu"
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        NumericUpDown1.Visible = False
        Button2.Visible = False
        Button2.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
        baglanti.Open()
        Dim sorgu As New OleDb.OleDbCommand("select * from urunstok where urn_adi='" + ComboBox1.SelectedItem + "'", baglanti)
        Dim tablo = New DataTable()
        tablo.Load(sorgu.ExecuteReader())
        DataGridView1.DataSource = tablo
        Dim getir As OleDb.OleDbDataReader = sorgu.ExecuteReader()
        getir.Read()
        ComboBox2.SelectedItem = getir("urn_kodu")
        Label6.Text = Convert.ToString(getir("urn_kodu"))
        Label7.Text = Convert.ToString(getir("urn_barkod"))
        Label8.Text = Convert.ToString(getir("urn_adi"))
        Label9.Text = Convert.ToString(getir("urn_miktari")) + " " + Convert.ToString(getir("urn_birim"))
        NumericUpDown1.Value = 0
        NumericUpDown1.Maximum = Convert.ToInt32(getir("urn_miktari"))
        baglanti.Close()
        Label11.Text = "Toplam Fiyat"
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        NumericUpDown1.Visible = True
        Button2.Visible = True
        Button2.Enabled = False
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
        baglanti.Open()
        Dim sorgu As New OleDb.OleDbCommand("select * from urunstok where urn_kodu='" + ComboBox2.SelectedItem + "'", baglanti)
        Dim tablo = New DataTable()
        tablo.Load(sorgu.ExecuteReader())
        DataGridView1.DataSource = tablo
        Dim getir As OleDb.OleDbDataReader = sorgu.ExecuteReader()
        getir.Read()
        ComboBox1.SelectedItem = getir("urn_adi")
        Label6.Text = Convert.ToString(getir("urn_kodu"))
        Label7.Text = Convert.ToString(getir("urn_barkod"))
        Label8.Text = Convert.ToString(getir("urn_adi"))
        Label9.Text = Convert.ToString(getir("urn_miktari")) + " " + Convert.ToString(getir("urn_birim"))
        NumericUpDown1.Value = 0
        NumericUpDown1.Maximum = Convert.ToInt32(getir("urn_miktari"))
        baglanti.Close()
        Label11.Text = "Toplam Fiyat"
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        NumericUpDown1.Visible = True
        Button2.Visible = True
        Button2.Enabled = False
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value <> 0 Then
            Button2.Enabled = True
            Label11.Text = Convert.ToString(NumericUpDown1.Value * Convert.ToInt32(DataGridView1.CurrentRow.Cells("urn_birim_fiyat").Value)) + " TL"
        Else
            Button2.Enabled = False
            Label11.Text = "Toplam Fiyat"
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim soru1 As DialogResult = MsgBox("Ürün Satışını Onaylıyor Musunuz?", MsgBoxStyle.YesNo, "Otomasyon Programı")
        If soru1 = Windows.Forms.DialogResult.Yes Then
            Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
            baglanti.Open()
            Dim sorgu1 As New OleDb.OleDbCommand("update urunstok set urn_miktari=urn_miktari-'" + Convert.ToString(NumericUpDown1.Value) + "' where urn_kodu='" + ComboBox2.SelectedItem + "' and urn_barkod='" + Label7.Text + "'", baglanti)
            sorgu1.ExecuteNonQuery()
            Dim sorgu2 As New OleDb.OleDbCommand("select * from urunstok where urn_adi='" + ComboBox1.SelectedItem + "' and urn_kodu='" + ComboBox2.SelectedItem + "'", baglanti)
            Dim tablo = New DataTable()
            tablo.Load(sorgu2.ExecuteReader())
            DataGridView1.DataSource = tablo
            Dim getir As OleDb.OleDbDataReader = sorgu2.ExecuteReader()
            getir.Read()
            Label6.Text = Convert.ToString(getir("urn_kodu"))
            Label7.Text = Convert.ToString(getir("urn_barkod"))
            Label8.Text = Convert.ToString(getir("urn_adi"))
            Label9.Text = Convert.ToString(getir("urn_miktari")) + " " + Convert.ToString(getir("urn_birim"))
            NumericUpDown1.Value = 0
            NumericUpDown1.Maximum = Convert.ToInt32(getir("urn_miktari"))
            MsgBox("Kalan Stok -- " + Label9.Text, MessageBoxIcon.Information, "Otomasyon Programı")
            baglanti.Close()
        Else
            NumericUpDown1.Value = 0
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
        baglanti.Open()
        Dim sorgu As New OleDb.OleDbCommand("select * from hammadde", baglanti)
        Dim tablo = New DataTable()
        tablo.Load(sorgu.ExecuteReader())
        DataGridView2.DataSource = tablo
        baglanti.Close()
        ComboBox3.Text = "Hammadde Adı"
        ComboBox4.Text = "Hammadde Kodu"
        TextBox1.Text = ""
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        Label22.Visible = False
        TextBox1.Visible = False
        Button4.Visible = False
        Button4.Enabled = False
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
        baglanti.Open()
        Dim sorgu As New OleDb.OleDbCommand("select * from hammadde where ham_adi='" + ComboBox3.SelectedItem + "'", baglanti)
        Dim tablo = New DataTable()
        tablo.Load(sorgu.ExecuteReader())
        DataGridView2.DataSource = tablo
        Dim getir As OleDb.OleDbDataReader = sorgu.ExecuteReader()
        getir.Read()
        ComboBox4.SelectedItem = getir("ham_kodu")
        Label17.Text = Convert.ToString(getir("ham_kodu"))
        Label18.Text = Convert.ToString(getir("ham_barkod"))
        Label19.Text = Convert.ToString(getir("ham_adi"))
        Label20.Text = Convert.ToString(getir("ham_miktari")) + " " + Convert.ToString(getir("ham_birim"))
        baglanti.Close()
        Label22.Text = "Ödenecek Tutar"
        TextBox1.Text = ""
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label22.Visible = True
        TextBox1.Visible = True
        Button4.Visible = True
        Button4.Enabled = False
    End Sub
    
    Private Sub ComboBox4_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
        baglanti.Open()
        Dim sorgu As New OleDb.OleDbCommand("select * from hammadde where ham_kodu='" + ComboBox4.SelectedItem + "'", baglanti)
        Dim tablo = New DataTable()
        tablo.Load(sorgu.ExecuteReader())
        DataGridView2.DataSource = tablo
        Dim getir As OleDb.OleDbDataReader = sorgu.ExecuteReader()
        getir.Read()
        ComboBox3.SelectedItem = getir("ham_adi")
        Label17.Text = Convert.ToString(getir("ham_kodu"))
        Label18.Text = Convert.ToString(getir("ham_barkod"))
        Label19.Text = Convert.ToString(getir("ham_adi"))
        Label20.Text = Convert.ToString(getir("ham_miktari")) + " " + Convert.ToString(getir("ham_birim"))
        baglanti.Close()
        Label22.Text = "Ödenecek Tutar"
        TextBox1.Text = ""
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label22.Visible = True
        TextBox1.Visible = True
        Button4.Visible = True
        Button4.Enabled = False
    End Sub

    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
       If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" And TextBox1.Text <> "0" Then
            Button4.Enabled = True
            Label22.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(DataGridView2.CurrentRow.Cells("ham_birim_fiyat").Value)) + " TL"
        Else
            Button4.Enabled = False
            Label22.Text = "Ödenecek Tutar"
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim soru2 As DialogResult = MsgBox("Hammadde Alımını Onaylıyor Musunuz?", MsgBoxStyle.YesNo, "Otomasyon Programı")
        If soru2 = Windows.Forms.DialogResult.Yes Then
            Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
            baglanti.Open()
            Dim sorgu1 As New OleDb.OleDbCommand("update hammadde set ham_miktari='" + Convert.ToString(Convert.ToInt32(DataGridView2.CurrentRow.Cells("ham_miktari").Value) + Convert.ToInt32(TextBox1.Text)) + "' where ham_kodu='" + ComboBox4.SelectedItem + "' and ham_barkod='" + Label18.Text + "'", baglanti)
            sorgu1.ExecuteNonQuery()
            Dim sorgu2 As New OleDb.OleDbCommand("select * from hammadde where ham_adi='" + ComboBox3.SelectedItem + "' and ham_kodu='" + ComboBox4.SelectedItem + "'", baglanti)
            Dim tablo = New DataTable()
            tablo.Load(sorgu2.ExecuteReader())
            DataGridView2.DataSource = tablo
            Dim getir As OleDb.OleDbDataReader = sorgu2.ExecuteReader()
            getir.Read()
            Label17.Text = Convert.ToString(getir("ham_kodu"))
            Label18.Text = Convert.ToString(getir("ham_barkod"))
            Label19.Text = Convert.ToString(getir("ham_adi"))
            Label20.Text = Convert.ToString(getir("ham_miktari")) + " " + Convert.ToString(getir("ham_birim"))
            TextBox1.Text = ""
            MsgBox("Güncel Stok -- " + Label20.Text, MessageBoxIcon.Information, "Otomasyon Programı")
            baglanti.Close()
        Else
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Label30_Click(sender As System.Object, e As System.EventArgs) Handles Label30.Click
        menu1_2_Click(menu1_2, New EventArgs())
    End Sub

    Private Sub Label30_MouseHover(sender As System.Object, e As System.EventArgs) Handles Label30.MouseHover
        Label30.ForeColor = Color.CornflowerBlue
    End Sub

    Private Sub Label30_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Label30.MouseLeave
        Label30.ForeColor = Color.DarkSlateBlue
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        Dim secim = ""
        If ComboBox5.SelectedIndex = 0 Then
            secim = "Şeftali"
        ElseIf ComboBox5.SelectedIndex = 1 Then
            secim = "Kayısı"
        ElseIf ComboBox5.SelectedIndex = 2 Then
            secim = "Vişne"
        ElseIf ComboBox5.SelectedIndex = 3 Then
            secim = "Çilek"
        ElseIf ComboBox5.SelectedIndex = 4 Then
            secim = "Elma"
        End If

        Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
        baglanti.Open()
        Dim sorgu1 As New OleDb.OleDbCommand("select ham_kodu,ham_adi,ham_miktari from hammadde where ham_adi like '%" + secim + "%'", baglanti)
        Dim tablo1 = New DataTable()
        tablo1.Load(sorgu1.ExecuteReader())
        DataGridView3.DataSource = tablo1
        Dim sorgu2 As New OleDb.OleDbCommand("select urn_kodu,urn_adi,urn_miktari from urunstok where urn_adi like '%" + secim + "%'", baglanti)
        Dim tablo2 = New DataTable()
        tablo2.Load(sorgu2.ExecuteReader())
        DataGridView4.DataSource = tablo2

        Button5.Visible = True
        Button6.Visible = True
        Button7.Visible = True
        Button8.Visible = True
        Button9.Visible = True

        If (Convert.ToInt32(DataGridView3.CurrentRow.Cells("ham_miktari1").Value) / 5) < 10 Then
            Button6.Enabled = False
        Else
            Button6.Enabled = True
        End If
        If (Convert.ToInt32(DataGridView3.CurrentRow.Cells("ham_miktari1").Value) / 5) < 50 Then
            Button7.Enabled = False
        Else
            Button7.Enabled = True
        End If
        If (Convert.ToInt32(DataGridView3.CurrentRow.Cells("ham_miktari1").Value) / 5) < 100 Then
            Button8.Enabled = False
        Else
            Button8.Enabled = True
        End If

        NumericUpDown2.Value = 0
        NumericUpDown2.Visible = True
        NumericUpDown2.Maximum = Convert.ToInt32(DataGridView3.CurrentRow.Cells("ham_miktari1").Value) / 5
        Label30.Visible = True
        Label27.Text = "1 LT " + Convert.ToString(DataGridView4.CurrentRow.Cells("urn_adi1").Value) + " Üretimi için 5 KG " + Convert.ToString(DataGridView3.CurrentRow.Cells("ham_adi1").Value) + " Gerekli."
        Label27.Visible = True
        Label28.Text = "Mevcut Olan -- " + Convert.ToString(DataGridView3.CurrentRow.Cells("ham_miktari1").Value) + " KG " + Convert.ToString(DataGridView3.CurrentRow.Cells("ham_adi1").Value)
        Label28.Visible = True
        Label29.Text = "Yapılabilecek " + Convert.ToString(DataGridView4.CurrentRow.Cells("urn_adi1").Value) + " Miktarı"
        Label29.Visible = True

        baglanti.Close()

    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        If NumericUpDown2.Value <> 0 Then
            Button9.Enabled = True
        Else
            Button9.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        NumericUpDown2.Value = Convert.ToInt32(DataGridView3.CurrentRow.Cells("ham_miktari1").Value) / 5
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        NumericUpDown2.Value = 10
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        NumericUpDown2.Value = 50
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        NumericUpDown2.Value = 100
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim soru3 As DialogResult = MsgBox(Convert.ToString(NumericUpDown2.Value) + Convert.ToString(" LT ") + Convert.ToString(DataGridView4.CurrentRow.Cells("urn_adi1").Value) + Convert.ToString(" Üretimini Onaylıyor Musunuz?") + vbCrLf + vbCrLf + Convert.ToString((NumericUpDown2.Value * 5)) + Convert.ToString(" KG ") + Convert.ToString(DataGridView3.CurrentRow.Cells("ham_adi1").Value) + Convert.ToString(" Kullanılacak."), MsgBoxStyle.YesNo, "Otomasyon Programı")
        If soru3 = DialogResult.Yes Then
            Dim secim = ""
            If ComboBox5.SelectedIndex = 0 Then
                secim = "Şeftali"
            ElseIf ComboBox5.SelectedIndex = 1 Then
                secim = "Kayısı"
            ElseIf ComboBox5.SelectedIndex = 2 Then
                secim = "Vişne"
            ElseIf ComboBox5.SelectedIndex = 3 Then
                secim = "Çilek"
            ElseIf ComboBox5.SelectedIndex = 4 Then
                secim = "Elma"
            End If

            Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
            baglanti.Open()
            Dim sorgu1 As New OleDb.OleDbCommand("update hammadde set ham_miktari='" + Convert.ToString(Convert.ToInt32(DataGridView3.CurrentRow.Cells("ham_miktari1").Value) - Convert.ToInt32(NumericUpDown2.Value * 5)) + "' where ham_kodu='" + DataGridView3.CurrentRow.Cells("ham_kodu1").Value + "' and ham_adi='" + DataGridView3.CurrentRow.Cells("ham_adi1").Value + "'", baglanti)
            sorgu1.ExecuteNonQuery()
            Dim sorgu2 As New OleDb.OleDbCommand("update urunstok set urn_miktari='" + Convert.ToString(Convert.ToInt32(DataGridView4.CurrentRow.Cells("urn_miktari1").Value) + NumericUpDown2.Value) + "' where urn_kodu='" + DataGridView4.CurrentRow.Cells("urn_kodu1").Value + "' and urn_adi='" + DataGridView4.CurrentRow.Cells("urn_adi1").Value + "'", baglanti)
            sorgu2.ExecuteNonQuery()

            Dim sorgu3 As New OleDb.OleDbCommand("select ham_kodu,ham_adi,ham_miktari from hammadde where ham_adi like '%" + secim + "%'", baglanti)
            Dim tablo1 = New DataTable()
            tablo1.Load(sorgu3.ExecuteReader())
            DataGridView3.DataSource = tablo1
            Dim sorgu4 As New OleDb.OleDbCommand("select urn_kodu,urn_adi,urn_miktari from urunstok where urn_adi like '%" + secim + "%'", baglanti)
            Dim tablo2 = New DataTable()
            tablo2.Load(sorgu4.ExecuteReader())
            DataGridView4.DataSource = tablo2

            If (Convert.ToInt32(DataGridView3.CurrentRow.Cells("ham_miktari1").Value) / 5) < 10 Then
                Button6.Enabled = False
            Else
                Button6.Enabled = True
            End If
            If (Convert.ToInt32(DataGridView3.CurrentRow.Cells("ham_miktari1").Value) / 5) < 50 Then
                Button7.Enabled = False
            Else
                Button7.Enabled = True
            End If
            If (Convert.ToInt32(DataGridView3.CurrentRow.Cells("ham_miktari1").Value) / 5) < 100 Then
                Button8.Enabled = False
            Else
                Button8.Enabled = True
            End If

            Label28.Text = "Mevcut Olan -- " + Convert.ToString(DataGridView3.CurrentRow.Cells("ham_miktari1").Value) + " KG " + Convert.ToString(DataGridView3.CurrentRow.Cells("ham_adi1").Value)

            MsgBox(Convert.ToString(NumericUpDown2.Value) + Convert.ToString(" KG ") + DataGridView4.CurrentRow.Cells("urn_adi1").Value + " Üretimi Başarıyla Tamamlandı.", MsgBoxStyle.Information, "Otomasyon Programı")

            NumericUpDown2.Value = 0
            NumericUpDown2.Maximum = Convert.ToInt32(DataGridView3.CurrentRow.Cells("ham_miktari1").Value) / 5

            baglanti.Close()
        Else
            NumericUpDown2.Value = 0
        End If

    End Sub
  
    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Dim soruu As DialogResult = MsgBox("Kullanıcı Bilgileri Güncellenecek. Onaylıyor Musunuz?", MsgBoxStyle.YesNo, "Otomasyon Programı")
        If soruu = DialogResult.Yes Then
            Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
            baglanti.Open()
            Dim sorgu1 As New OleDb.OleDbCommand("update kullanici set usr_sifre='" + TextBox2.Text + "', usr_sirket_adi='" + TextBox3.Text + "', usr_telno='" + TextBox4.Text + "', usr_sirket_adresi='" + TextBox5.Text + "' where usr_kadi='" + Label41.Text + "' and usr_tcno='" + Label40.Text + "'", baglanti)
            sorgu1.ExecuteNonQuery()
            baglanti.Close()
           
            MsgBox("Güncelleme Başarıyla Tamamlandı.", MessageBoxIcon.Information, "Otomasyon Programı")

            Label42.Text = TextBox2.Text
            Label43.Text = TextBox3.Text
            Label44.Text = TextBox4.Text
            Label45.Text = TextBox5.Text

            Button10.Enabled = False
        End If

    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        TextBox2.Text = Label42.Text
        TextBox3.Text = Label43.Text
        TextBox4.Text = Label44.Text
        TextBox5.Text = Label45.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = Label42.Text And TextBox3.Text = Label43.Text And
                TextBox4.Text = Label44.Text And TextBox5.Text = Label45.Text Then
            Button10.Enabled = False
        Else
            Button10.Enabled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox2.Text = Label42.Text And TextBox3.Text = Label43.Text And
                TextBox4.Text = Label44.Text And TextBox5.Text = Label45.Text Then
            Button10.Enabled = False
        Else
            Button10.Enabled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox2.Text = Label42.Text And TextBox3.Text = Label43.Text And
                TextBox4.Text = Label44.Text And TextBox5.Text = Label45.Text Then
            Button10.Enabled = False
        Else
            Button10.Enabled = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox2.Text = Label42.Text And TextBox3.Text = Label43.Text And
                TextBox4.Text = Label44.Text And TextBox5.Text = Label45.Text Then
            Button10.Enabled = False
        Else
            Button10.Enabled = True
        End If
    End Sub
End Class