   M S B A M L   `   `   `  ����   SIPI_SL9    3SIPI_SL.UI.ResultManagement.CourseAssignToTracherUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$!  Course Assign To Teacher UI��$��444.781��$��803.231�� � WindowState$ 	Maximized=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ CanMinimize=�   	GrayWhite#��[   � ShowInTaskbar .  .��� .+��� $
��Left=�$��
128,28,0,0q�$	��Top=�$	��254��  ComboBoxBGYellowGreen#��[ �� $��
Department��$
��Left=�$��	15,37,0,0q�$	��Top=�$	��106���� $
��Left=�$��
128,70,0,0q�$	��Top=�$	��130��#��[ �� $
��Year��$
��Left=�$��	16,73,0,0q�$	��Top=�$��66���� $�� ��$
��Left=�$��
263,70,0,0q�$	��Top=�$	��119��$��51��  SearchButton#���  �� $��Assign��$
��Left=�$��677,365,0,0q�$	��Top=�$	��108��$��36��&   System.Windows.Controls.DataGrid  -   $��StudentListDataGrid��   AutoGenerateColumns .  $	��219��$
��Left=�$��
16,141,0,0q�$	��Top=�$	��400��   CanUserAddRows .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Teacher's Name��	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 ��  �� Path$ ApplicantName�  $ Teacher Code��$
	 auto 
 �� $ 	StudentId�4  .System.Windows.Controls.DataGridTemplateColumn   �� -   $��CheckALL��$��
Select All��{�.     CellTemplate �� .R��� $��chkDiscontinue��-   $��45 2 0 0q� d� 	IsChecked �� *	IsChecked+ �� ElementName$ CheckALL�� �� Mode$ OneWay=�  -   $��CourseListDataGrid�� .  $	��219��$��421,141,0,0q�$	��Top=� .  $
��Left=�$	��364��   $ 
Department��$
	 auto 
 �� $ SIPI_Department�  $ Semester��$
	 auto 
 �� $ 
SemesterNo�  $ Course Name��$
	 auto 
 �� $ 
CourseName�  $ 	Course Id��$
	 auto 
 �� $ CourseId��� $
��Left=�$��
554,28,0,0q�$	��Top=�$	��156��#��[ �� $��Assign to Semester Course��$
��Left=�$��
388,33,0,0q�$	��Top=�$	��166��