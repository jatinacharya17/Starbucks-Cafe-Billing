Imports MySql.Data.MySqlClient

Public Class DB

    Public Shared conn As New MySqlConnection(
        "Server=127.0.0.1;Port=3306;Database=cafe_db;Uid=root;Pwd=Jatin@17"
    )

    Public Shared Sub Open()

        Try

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Public Shared Sub Close()

        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class