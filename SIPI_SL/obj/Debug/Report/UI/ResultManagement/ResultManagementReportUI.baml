   M S B A M L   `   `   `  ����  SIPI_SLA    ;SIPI_SL.Report.UI.ResultManagement.ResultManagementReportUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Student's Marks Report UI��5   	   $	��606��6+   $
��1063��68    � WindowState$ 	Maximized=�5   	    � WindowStartupLocation$ CenterScreen=�6!    � 
ResizeMode$ CanMinimize=�5   	      	GrayWhite#��[  6#    � ShowInTaskbar .  .��5      � .+�5   
   � $��
85,10,77,0q�6   $��Center=�6#   #��� ��6@   $	��895��6�   $	��557��6�   $	��Top=�6�   .+�5	      �� -   5        $��departmentCombobox��5	      $
��Left=�61   $��
142,22,0,0q�6L   $	��Top=�6`   $	��254��6x     ComboBoxBGYellowGreen#��[ 6�   �� 5
      $��
Department��6   $
��Left=�6*   $��	32,22,0,0q�6E   $	��Top=�6X   $	��106��6p   �� 5      -   5        $��semesterCombobox��5      $
��Left=�6/   $��
142,58,0,0q�6J   $	��Top=�6^   $	��119��6v   #��[ 6�   �� 5      $��Semester��6   $
��Left=�6(   $��	32,58,0,0q�6C   $	��Top=�6V   $	��110��6n   �� 5      -   5        $��yearCombobox��5      $
��Left=�6+   $��
142,97,0,0q�6F   $	��Top=�6Z   $	��119��6r   #��[ 6~   �� 5      $
��Year��6   $
��Left=�6$   $��	34,97,0,0q�6?   $	��Top=�6R   $��66��6j   �� 5      -   5        $��searchButton��5   �   $�� ��6   $
��Left=�6    $��
266,58,0,0q�6;   $	��Top=�6O   $	��130��6g   $��73��6s     SearchButton#���  6   6�   �� 5      -   5        $��studentResultReportButton��5   �   $��Student Result��6   $
��Left=�6.   $��763,528,0,0q�6I   $	��Top=�6^   $	��108��6v   $��24��6�   6�   &   System.Windows.Controls.DataGrid  5      -   5        $��StudentMarksEntryDataGrid��5   #      AutoGenerateColumns .  $��Center=�5   )   $��24,178,20,34q�5      $	��851��6D      CanUserAddRows .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Department��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 auto 6e   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   ��  �� Path$ DepartmentName�6e     5      $	 Semester��6)   $

 auto 6_    6;   �� $ 
SemesterNo�6_     5      $	 Student Name��6)   $

 auto 6d    6?   �� $ StudentName�6d     5      $	 
Srudent Id��6)   $

 auto 6`    6=   �� $ 	StudentId�6`     5      $	 Course Name��6)   $

 auto 6b    6>   �� $ 
CourseName�6b     5      $	 Theoty Con. Asses��6)   $

 auto 6r    6D   �� $ TheoryMarksConAssess�6r     5      $	 Practical Con. Asses��6)   $

 auto 6x    6G   �� $ PracticalMarksConAssess�6x     5      $	 Theoty Final Exam��6)   $

 auto 6r    6D   �� $ TheoryMarksFinalExam�6r     5      $	 Practical Final Exam��6)   $

 auto 6x    6G   �� $ PracticalMarksFinalExam�6x     5       $	 Total Marks��6)   $

 auto 6b    6>   �� $ 
TotalMarks�6b   5"      �� 5#      $��
Student ID��6   $
��Left=�6*   $��
34,136,0,0q�6E   $	��Top=�6Y   $	��108��6q   �� 5$      -   5        $��studentIdTextBox��5$   f   $
��Left=�6   $��37��61   $��142,134,0,0q�6=    �� TextWrapping$
 Wrap=�6R   $	��Top=�6~   $	��254��6�   ���	#FFE9E9E96�   �� 5%      -   5         ��Name$$ studentBoardResultReportButton��5%   �   $��Board Result��6   $
��Left=�6,   $��650,528,0,0q�6G   $	��Top=�6\   $	��108��6t   $��24��6�   6�   5&      5'      5(      