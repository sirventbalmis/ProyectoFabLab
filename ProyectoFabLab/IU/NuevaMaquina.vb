Imports System.Data.SqlClient

Public Class NuevaMaquina
    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click

        Me.Close()

    End Sub

    Private Sub NuevaMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarTiposMaquinas()

    End Sub

    Private Sub CargarTiposMaquinas()

        Dim tablaTiposMaquinas As SqlDataReader = NegocioTiposMaquinas.ObtenerTiposMaquinas()

        While tablaTiposMaquinas.Read()

            TipoMaquinaComboBox.Items.Add(tablaTiposMaquinas.GetString(0))

        End While

    End Sub

End Class