   M S B A M L   `   `   `  ����   SIPI_SLA    ;SIPI_SL.Report.UI.ResultManagement.ResultManagementReportUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Student's Marks Report UI��$	��606��$
��1063�� � WindowState$ 	Maximized=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ CanMinimize=�   	GrayWhite#��[   � ShowInTaskbar .  .��� .+�� $��
85,10,77,0q�$��Center=�#��� ��$	��895��$	��557��$	��Top=�.+��� -   $��departmentCombobox��$
��Left=�$��
142,22,0,0q�$	��Top=�$	��254��  ComboBoxBGYellowGreen#��[ �� $��
Department��$
��Left=�$��	32,22,0,0q�$	��Top=�$	��106���� -   $��semesterCombobox��$
��Left=�$��
142,58,0,0q�$	��Top=�$	��119��#��[ �� $��Semester��$
��Left=�$��	32,58,0,0q�$	��Top=�$	��110���� -   $��yearCombobox��$
��Left=�$��
142,97,0,0q�$	��Top=�$	��119��#��[ �� $
��Year��$
��Left=�$��	34,97,0,0q�$	��Top=�$��66���� -   $��searchButton��$�� ��$
��Left=�$��
266,58,0,0q�$	��Top=�$	��130��$��73��  SearchButton#���  �� -   $��studentResultReportButton��$��Student Result��$
��Left=�$��763,528,0,0q�$	��Top=�$	��108��$��24��&   System.Windows.Controls.DataGrid  -   $��StudentMarksEntryDataGrid��   AutoGenerateColumns .  $��Center=�$��24,178,20,34q�$	��851��   CanUserAddRows .     
IsReadOnly .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Department��
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 auto 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ DepartmentName�  $	 Semester��$

 auto  �� $ 
SemesterNo�  $	 Student Name��$

 auto  �� $ StudentName�  $	 
Srudent Id��$

 auto  �� $ 	StudentId�  $	 Course Name��$

 auto  �� $ 
CourseName�  $	 Theoty Con. Asses��$

 auto  �� $ TheoryMarksConAssess�  $	 Practical Con. Asses��$

 auto  �� $ PracticalMarksConAssess�  $	 Theoty Final Exam��$

 auto  �� $ TheoryMarksFinalExam�  $	 Practical Final Exam��$

 auto  �� $ PracticalMarksFinalExam�  $	 Total Marks��$

 auto  �� $ 
TotalMarks��� $��
Student ID��$
��Left=�$��
34,136,0,0q�$	��Top=�$	��108���� -   $��studentIdTextBox��$
��Left=�$��37��$��142,134,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��254�����	#FFE9E9E9�� -    ��Name$$ studentBoardResultReportButton��$��Board Result��$
��Left=�$��650,528,0,0q�$	��Top=�$	��108��$��24��