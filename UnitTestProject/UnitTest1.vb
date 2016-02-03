Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VBSamples

<TestClass()> Public Class UnitTest

    <TestMethod()> Public Sub TestMethod()
        Class1.Main()
    End Sub



    <TestMethod()> Public Sub TestSubString()

        'Dim a = "12345"
        'Dim b = a.Substring(5, -2)

        Dim c As String = Nothing

        Dim d = c & "a"

        Console.WriteLine(d)
    End Sub

End Class