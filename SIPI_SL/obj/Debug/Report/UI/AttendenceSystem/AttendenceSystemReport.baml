   M S B A M L   `   `   `  ����  SIPI_SL?    9SIPI_SL.Report.UI.AttendenceSystem.AttendenceSystemReport   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   a
extToolkitJhttp://schemas.microsoft.com/winfx/2006/xaml/presentation/toolkit/extended     5   	     � Title$  Attendance Reposrt��5   	   $��353.356��6$   $��621.197��65      	GrayWhite#��[  6F    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6�   .��5      � .+�5   
   � .+�5      �� -   5        $��yearTextBox��5      $�� ��6   $��15(�61    J� SnapsToDevicePixels .   �� SelectionBrush �	#FF5677B1$��
338,29,0,0q�6v   $��33��6�   $	��Top=�6�   $
��Left=�6�   $��92��6�   �� 5
      -   5        $��previewReportButton��5
   �   $��Preview��6   $
��Left=�6'   $	��Top=�6B   $��75��6Z   $��
514,35,0,0q�6e   $��24��6y   6�   �� 5      -   5        $��searchButton��5   �   $��Search��6   $
��Left=�6&   $	��Top=�6A   $��75��6Y   $��
433,35,0,0q�6d   $��24��6x   6�   �� 5      -   5        $��departmentCombobox��5   !    �� 
IsEditable .  w� TextPath$ SIPI_DepartmentName��5   !   $
��Left=�5   !   $��	53,30,0,0q�5   !   $	��Top=�5   !   $	��152��5   !    J� RenderTransformOrigin$ 0.037,0.146&�5   !   $��33��5   ;   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $	��200��6M   ��6(   �� *SIPI_DepartmentName+6M   5      5      5      �� 5      -   5        	 ��Name$	 semesterCombobox��5'       . $ 
SemesterNo��5!      $
��Left=�5"      $��
210,29,0,0q�5#      $	��Top=�5$      $	��123��5%      $ 0.037,0.146&�5&      $��34��5'   (   ��5(      �� 5)      .R�5*      �� $ 
Horizontal=�6%   .+�5+      �� $	��130��6D   ��6(   �� *
SemesterNo+6D   5,      5-      5/      �� 50      $��
Department��6   $
��Left=�6)   $��51,0,0,0q�6D   $	��Top=�6V   $	��154��6n   $��30��6z   $��15(�6�   $
��Bold"�6�   �� 51      $��Semester��6   $
��Left=�6'   $��	210,0,0,0q�6B   $	��Top=�6U   $	��123��6m   $��30��6y   $��15(�6�   $
��Bold"�6�   (  "System.Windows.Controls.DatePicker  52      -   5        $��reportSearchDatepicker��52   w   $
��Left=�6   $��	53,68,0,0q�64   $	��Top=�6G   $	��152��6_   $��29��6k   6w   �� 53      $
��Year��6   $
��Left=�6#   $��
333,-1,0,0q�6>   $	��Top=�6R   $��97��6j   $��30��6u   $��15(�6�   $
��Bold"�6�   54      �� 56   
   -   5        $"��allStudentAttendenceListView��57      $
��Left=�56      $	��211��6.   $��
60,101,0,0q�6;   $	��Top=�6O   $	��518��6g      alternatingListViewItemStyle#��[ 57   7   
 �� View
 5:      �� 5;       �� AllowsColumnReorder . .P�5<      �� $�� ��6I    �� Width$ 0��6S    �� DisplayMemberBinding 6%   �� *Id+6S   �� 5=      $��Student Name ��6R   $	 100��6i    6%   �� *StudentName+6i   �� 5>      $��
Department��6U   $	 100��6i    6%   �� *DepartmentName+6i   �� 5?      $��	Semester ��6Q   $	 100��6d    6%   �� *
SemesterNo+6d   �� 5@      $��Date ��6K   $	 100��6Z    6%   �� *Date+6Z   �� 5A      $��Status ��6M   $	 100��6^    6%   �� *Status+6^   5C      5E      5G      5H      