   M S B A M L   `   `   `  ����  SIPI_SL5    /SIPI_SL.UI.AttendenceSystem.StudentAttendenceUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Student Attendence UI��5   	   $��506.646��6'    � WindowState$ 	Maximized=�68    � WindowStartupLocation$ CenterScreen=�6P      	GrayWhite#��[  6u    � ShowInTaskbar .  $��786.562��6�   .��5      � .+�5   
   �� -   5        $��departmentCombobox��5
       �� 
IsEditable .  w� TextPath$ SIPI_DepartmentName��5       J� RenderTransformOrigin$ 0.037,0.146&�5	      $��	60,33,0,0q�5
   +   $
��Left=�6>   $	��219��6Y   $��33��6e   $	��Top=�6q   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $	��130��6I   ��6$   �� *SIPI_DepartmentName+6I   5      5      5      �� 5   
   -   5        $��searchButton��5   "   $��Search��6   $��	0,37,47,0q�6Q   $��24��6d   $	��Top=�6p   $��Right=�6�   $��75��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��studentListDataGrid��5      $��60,76,47,74q�6.      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   
IsReadOnly	 . 
   Header$
 
Department��6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ DepartmentName�6_     5      $
 Semester��6I   	 .  6%   �� $ 
SemesterNo�6\     5      $

 Year��6L   	 .  6%   �� $ AccadamicYear�6Z     5       $
 Student Name��6L   	 .  6%   �� $ ApplicantName�6b   4  .System.Windows.Controls.DataGridTemplateColumn  5"      
 5#      �� 5$      -   5        $��CheckALL��5$   #   $��Discontinue All��63   {�.  6M      CellTemplate 5&      �� 5'      .R�5(      �� $��chkDiscontinue��6'   -   5        $��45 2 0 0q�5(   =    d� 	IsChecked 6O   �� *	IsChecked+ �� ElementName$ CheckALL�� �� Mode$ OneWay=�5)   O   5*      5,      50      �� 51   
   -   5         ��Name$ insertAttendenceButton��51   ?   $
��Bold"�6   $��Insert Attendence��6#   $��	0,0,47,46q�6_   $��24��6r   $��Bottom=�6~   $��Right=�6�   $	��111��6�   6�   (  "System.Windows.Controls.DatePicker  52   
   -   5        $��attendenceDatePicker��52      $��60,4,0,0q�61   $	��Top=�6C   $
��Left=�6\   $	��102��6w   �� 53   
   -   5         ��Name$ semesterCombobox��57   
    . $ 
SemesterNo��55   
   $ 0.037,0.146&�56   
   $��
284,33,0,0q�57   $   $
��Left=�68   $��77��6S   $��33��6^   $	��Top=�6j   ��59      �� 5:      .R�5;      �� $ 
Horizontal=�6!   .+�5=      �� $	��130��6@   ��6$   �� *
SemesterNo+6@   5?      5@      5B      �� 5C   
   -	   5        $ campusCombobox��5G   
    . $ 
CampusName��5E   
   $ 0.037,0.146&�5F   
   $��
367,32,0,0q�5G   "   $
��Left=�66   $	��171��6Q   $��33��6]   $	��Top=�6i   ��5I      �� 5J      .R�5K      �� $ 
Horizontal=�6!   .+�5M      �� $	��130��6@   ��6$   �� *
CampusName+6@   5O      5P      5R      �� 5S   
   -
   5        $��yearCombobox��5W   
    . $
 Year��5U   
   $ 0.037,0.146&�5V   
   $��
543,32,0,0q�5W      $
��Left=�62   $��91��6M   $��33��6X   $	��Top=�6d   ��5Y      �� 5Z      .R�5[      �� $ 
Horizontal=�6!   .+�5]      �� $	��130��6:   ��6$   �� *Year+6:   5_      5`      5b      5f      5g      