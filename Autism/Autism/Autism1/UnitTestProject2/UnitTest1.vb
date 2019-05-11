Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Autism1

<TestClass>
Public Class RandomNumberGeneratorTest1
    <TestMethod>
    Sub TestSub()
        Dim form1 As New Main

        Dim low = 1
        Dim high = 100

        For counter As Integer = 1 To 100
            Dim random = form1.GenRandomInt(low, high)
            Debug.Print("Testing: " & random)
            Assert.IsTrue(random >= low And random <= high)
            Debug.Print("PASSED")
        Next counter
    End Sub
End Class

<TestClass>
Public Class RandomNumberGeneratorTest2
    <TestMethod>
    Sub TestSub()
        Dim form1 As New Main

        Dim low = 50
        Dim high = 75

        For counter As Integer = 1 To 100
            Dim random = form1.GenRandomInt(low, high)
            Debug.Print("Testing: " & random)
            Assert.IsTrue(random >= low And random <= high)
            Debug.Print("PASSED")
        Next counter
    End Sub
End Class

<TestClass>
Public Class RandomNumberGeneratorTest3
    <TestMethod>
    Sub TestSub()
        Dim form1 As New Main

        Dim low = 1000
        Dim high = 2000

        For counter As Integer = 1 To 100
            Dim random = form1.GenRandomInt(low, high)
            Debug.Print("Testing: " & random)
            Assert.IsTrue(random >= low And random <= high)
            Debug.Print("PASSED")
        Next counter
    End Sub
End Class

<TestClass>
Public Class RandomNumberGeneratorTest4
    <TestMethod>
    Sub TestSub()
        Dim form1 As New Main

        Dim low = 100000
        Dim high = 100001

        For counter As Integer = 1 To 100
            Dim random = form1.GenRandomInt(low, high)
            Debug.Print("Testing: " & random)
            Assert.IsTrue(random >= low And random <= high)
            Debug.Print("PASSED")
        Next counter
    End Sub
End Class

<TestClass>
Public Class RandomNumberGeneratorTest5
    <TestMethod>
    Sub TestSub()
        Dim form1 As New Main

        Dim low = -100
        Dim high = -1

        For counter As Integer = 1 To 100
            Dim random = form1.GenRandomInt(low, high)
            Debug.Print("Testing: " & random)
            Assert.IsTrue(random >= low And random <= high)
            Debug.Print("PASSED")
        Next counter
    End Sub
End Class