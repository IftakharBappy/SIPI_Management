   M S B A M L   `   `   `  ����   SIPI_SL5    /SIPI_SL.UI.AttendenceSystem.StudentAttendenceUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Student Attendence UI��$��506.646�� � WindowState$ 	Maximized=� � WindowStartupLocation$ CenterScreen=�   	GrayWhite#��[   � ShowInTaskbar .  $��786.562��.��� .+��� -   $��departmentCombobox�� �� 
IsEditable .  w� TextPath$ SIPI_DepartmentName�� J� RenderTransformOrigin$ 0.037,0.146&�$��	60,33,0,0q�$
��Left=�$	��219��$��33��$	��Top=����� .R���  �� Orientation$ 
Horizontal=�.+��� $	��130������ *SIPI_DepartmentName+�� -   $��searchButton��$��Search��$��	0,37,47,0q�$��24��$	��Top=�$��Right=�$��75��&   System.Windows.Controls.DataGrid  -   $��studentListDataGrid��$��60,76,47,74q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   
IsReadOnly	 . 
   Header$
 
Department��1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ DepartmentName�  $
 Semester��	 .  �� $ 
SemesterNo�  $

 Year��	 .  �� $ AccadamicYear�  $
 Student Name��	 .  �� $ ApplicantName�4  .System.Windows.Controls.DataGridTemplateColumn  
 �� -   $��CheckALL��$��Discontinue All��{�.     CellTemplate �� .R��� $��chkDiscontinue��-   $��45 2 0 0q� d� 	IsChecked �� *	IsChecked+ �� ElementName$ CheckALL�� �� Mode$ OneWay=��� -    ��Name$ insertAttendenceButton��$
��Bold"�$��Insert Attendence��$��	0,0,47,46q�$��24��$��Bottom=�$��Right=�$	��111��(  "System.Windows.Controls.DatePicker  -   $��attendenceDatePicker��$��60,4,0,0q�$	��Top=�$
��Left=�$	��102���� -    ��Name$ semesterCombobox�� . $ 
SemesterNo��$ 0.037,0.146&�$��
284,33,0,0q�$
��Left=�$��77��$��33��$	��Top=����� .R��� $ 
Horizontal=�.+��� $	��130������ *
SemesterNo+�� -	   $ campusCombobox�� . $ 
CampusName��$ 0.037,0.146&�$��
367,32,0,0q�$
��Left=�$	��171��$��33��$	��Top=����� .R��� $ 
Horizontal=�.+��� $	��130������ *
CampusName+�� -
   $��yearCombobox�� . $
 Year��$ 0.037,0.146&�$��
543,32,0,0q�$
��Left=�$��91��$��33��$	��Top=����� .R��� $ 
Horizontal=�.+��� $	��130������ *Year+