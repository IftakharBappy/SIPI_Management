   M S B A M L   `   `   `  ����   SIPI_SL>    8SIPI_SL.UI.ResultManagement.MarksDistributionToStudentUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$&   Marks Distribution To Student UI��$	��606��$
��1063�� � WindowState$ 	Maximized=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ CanMinimize=�   	GrayWhite#��[   � ShowInTaskbar .  .��� .+�� $��
85,10,77,0q�$��Center=�#��� ��$	��895��$	��557��$	��Top=�.+��� -   $��departmentCombobox��$
��Left=�$��
142,22,0,0q�$	��Top=�$	��254��  ComboBoxBGYellowGreen#��[ �� $��
Department��$
��Left=�$��	32,22,0,0q�$	��Top=�$	��106���� -   $��semesterCombobox��$
��Left=�$��142,100,0,0q�$	��Top=�$	��119��#��[ �� $��Semester��$
��Left=�$��
32,100,0,0q�$	��Top=�$	��110���� -   $��yearCombobox��$
��Left=�$��142,139,0,0q�$	��Top=�$	��119��#��[ �� $
��Year��$
��Left=�$��
34,139,0,0q�$	��Top=�$��66���� -   $��searchButton��$�� ��$
��Left=�$��266,100,0,0q�$	��Top=�$	��130��$��73��  SearchButton#���  �� -   $��marksEntryButton��$��Entry��$
��Left=�$��763,528,0,0q�$	��Top=�$	��108��$��24��&   System.Windows.Controls.DataGrid  -   $��StudentMarksEntryDataGrid��   AutoGenerateColumns .  $��Center=�$��20,178,24,34q�$	��851��   CanUserAddRows .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
Department��	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ DepartmentName�  $ Semester��$
	 auto 
 .  �� $ 
SemesterNo�  $ Student Name��$
	 auto 
 .  �� $ StudentName�  $ 
Srudent Id��$
	 auto 
 .  �� $ 	StudentId�4  .System.Windows.Controls.DataGridTemplateColumn  $ Theoty Con. Asses��$		 100 
 .    CellTemplate �� .R��� $��theotyConAssesTextBox��-   ���� $ TheoryMarksConAssess� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  $ Practical Con. Asses��$		 100 
 .  �� .R��� $��PracticalConAssesTextBox��-   ���� $ PracticalMarksConAssess�$ TwoWay=�$ PropertyChanged=�  $ Theoty Final Exam��$		 100 
 .  �� .R��� $��theotyFinalExamTextBox��-	   ���� $ TheoryMarksFinalExam�$ TwoWay=�$ PropertyChanged=�  $ Practical Final Exam��$		 100 
 .  �� .R��� $��practicalFinalExamTextBox��-
   ���� $ PracticalMarksFinalExam�$ TwoWay=�$ PropertyChanged=�  $ Total Marks��$
	 auto 
 .  �� $ 
TotalMarks��� -   $��courseCombobox��$
��Left=�$��
142,61,0,0q�$	��Top=�$	��254��#��[ �� $��Course��$
��Left=�$��	34,61,0,0q�$	��Top=�$	��108��