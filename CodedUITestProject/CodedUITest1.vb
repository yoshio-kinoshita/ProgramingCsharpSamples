Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Windows.Input
Imports Microsoft.VisualStudio.TestTools.UITest.Extension
Imports Microsoft.VisualStudio.TestTools.UITesting
Imports Microsoft.VisualStudio.TestTools.UITesting.Keyboard
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<CodedUITest()>
Public Class CodedUITest1

        <TestMethod()>
        Public Sub CodedUITestMethod1()
            '            
            ' このテストのコードを生成するには、ショートカット メニューの [コード化された UI テストのコードの生成] をクリックし、メニュー項目の 1 つをクリックします。
            '
        End Sub

#Region "追加のテスト属性"
        '
        ' テストを作成する際には、次の追加属性を使用できます。
        '
        '' 各テストを実行する前に、TestInitialize を使用してコードを実行してください
        '<TestInitialize()> Public Sub MyTestInitialize()
        '    '
        '    ' このテストのコードを生成するには、ショートカット メニューの [コード化された UI テストのコードの生成] をクリックし、メニュー項目の 1 つをクリックします。
        '    '
        'End Sub

        '' 各テストを実行した後に、TestCleanup を使用してコードを実行してください
        '<TestCleanup()> Public Sub MyTestCleanup()
        '    '
        '    ' このテストのコードを生成するには、ショートカット メニューの [コード化された UI テストのコードの生成] をクリックし、メニュー項目の 1 つをクリックします。
        '    '
        'End Sub

#End Region

        '''<summary>
        '''現在のテストの実行についての情報および機能を
        '''提供するテスト コンテキストを取得または設定します。
        '''</summary>
        Public Property TestContext() As TestContext
            Get
                Return testContextInstance
            End Get
            Set(ByVal value As TestContext)
                testContextInstance = Value
            End Set
        End Property

        Private testContextInstance As TestContext
    End Class
