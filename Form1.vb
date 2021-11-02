Imports System.Data
Imports System.Data.OleDb
Public Class Form1

    Public Shared goad As String

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Width = 500
        Me.Height = 375
        Me.CenterToScreen()
    End Sub

    Private Sub Form1_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Label3_MouseHover(sender As System.Object, e As System.EventArgs) Handles Label3.MouseHover
        Label3.ForeColor = Color.SkyBlue
    End Sub

    Private Sub Label3_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.White
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel2.Location = New Point(0, 0)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Panel1.Visible = True
        Panel2.Visible = False
    End Sub

    Dim sorwwgu As New SqlClient.SqlDataAdapter()
    Dim getir As SqlClient.SqlDataReader
    Dim baglanti As New SqlClient.SqlConnection("Integrated Security=SSPI;Data Source=vt.mdb")

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
        baglanti.Open()
        Dim sorgu As New OleDb.OleDbCommand("select * from kullanici where usr_kadi='" + TextBox1.Text + "' and usr_sifre='" + TextBox2.Text + "'", baglanti)
        Dim getir As OleDb.OleDbDataReader = sorgu.ExecuteReader()
        If (getir.Read()) Then
            Me.Hide()
            Form2.Show()

            goad = TextBox1.Text

        Else
            MsgBox("Hatalı Giriş!!!", MsgBoxStyle.Critical, "Otomasyon Programı")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
        baglanti.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        If (TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or
             TextBox7.TextLength <> 11 Or TextBox8.TextLength <> 11 Or TextBox9.Text = "" Or TextBox10.Text = "") Then
            MsgBox("Tüm Alanları Doldurunuz!!!", MsgBoxStyle.Critical, "Otomasyon Programı")
        Else
            Dim baglanti As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb")
            baglanti.Open()
            Dim sorgu As New OleDb.OleDbCommand("insert into kullanici (usr_kadi,usr_sifre,usr_adi,usr_soyadi,usr_tcno,usr_telno,usr_sirket_adi,usr_sirket_adresi) values ('" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "')", baglanti)
            sorgu.ExecuteNonQuery()
            baglanti.Close()
            TextBox1.Text = TextBox3.Text
            TextBox2.Text = TextBox4.Text
            TextBox3.Text = ("")
            TextBox4.Text = ("")
            TextBox5.Text = ("")
            TextBox6.Text = ("")
            TextBox7.Text = ("")
            TextBox8.Text = ("")
            TextBox9.Text = ("")
            TextBox10.Text = ("")
            MsgBox("Kayıt İşlemi Başarıyla Tamamlandı.", MsgBoxStyle.Information, "Otomasyon Programı")
            Panel1.Visible = True
            Panel2.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        TextBox3.Text = ("")
        TextBox4.Text = ("")
        TextBox5.Text = ("")
        TextBox6.Text = ("")
        TextBox7.Text = ("")
        TextBox8.Text = ("")
        TextBox9.Text = ("")
        TextBox10.Text = ("")
    End Sub

End Class
