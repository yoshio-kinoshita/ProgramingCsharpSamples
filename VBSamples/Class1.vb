Public Class Class1
    'エントリポイント
    Public Shared Sub Main()
        Console.WriteLine("スタート")

        'DoSomethingメソッドを別のスレッドで実行する
        'Threadオブジェクトを作成する
        Dim t As New System.Threading.Thread( _
            New System.Threading.ThreadStart( _
            AddressOf DoSomething))
        'スレッドを開始する
        t.Start()

        Console.WriteLine("Enterキーを押してください")

    End Sub

    '別スレッドで実行するメソッド
    Private Shared Sub DoSomething()
        '長い時間のかかる処理があるものとする

        '処理が終わったことを知らせる
        Console.WriteLine("終わりました")
    End Sub
End Class