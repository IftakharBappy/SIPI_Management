   M S B A M L   `   `   `  ����   SIPI_SL?    9SIPI_SL.Report.UI.AttendenceSystem.AttendenceSystemReport   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     a
extToolkitJhttp://schemas.microsoft.com/winfx/2006/xaml/presentation/toolkit/extended       � Title$  Attendance Reposrt��$��353.356��$��621.197��   	GrayWhite#��[   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.��� .+�� .+��� -   $��yearTextBox��$�� ��$��15(� J� SnapsToDevicePixels .   �� SelectionBrush �	#FF5677B1$��
338,29,0,0q�$��33��$	��Top=�$
��Left=�$��92���� -   $��previewReportButton��$��Preview��$
��Left=�$	��Top=�$��75��$��
514,35,0,0q�$��24���� -   $��searchButton��$��Search��$
��Left=�$	��Top=�$��75��$��
433,35,0,0q�$��24���� -   $��departmentCombobox�� �� 
IsEditable .  w� TextPath$ SIPI_DepartmentName��$
��Left=�$��	53,30,0,0q�$	��Top=�$	��152�� J� RenderTransformOrigin$ 0.037,0.146&�$��33������ .R���  �� Orientation$ 
Horizontal=�.+��� $	��200������ *SIPI_DepartmentName+�� -   	 ��Name$	 semesterCombobox�� . $ 
SemesterNo��$
��Left=�$��
210,29,0,0q�$	��Top=�$	��123��$ 0.037,0.146&�$��34������ .R��� $ 
Horizontal=�.+��� $	��130������ *
SemesterNo+�� $��
Department��$
��Left=�$��51,0,0,0q�$	��Top=�$	��154��$��30��$��15(�$
��Bold"��� $��Semester��$
��Left=�$��	210,0,0,0q�$	��Top=�$	��123��$��30��$��15(�$
��Bold"�(  "System.Windows.Controls.DatePicker  -   $��reportSearchDatepicker��$
��Left=�$��	53,68,0,0q�$	��Top=�$	��152��$��29���� $
��Year��$
��Left=�$��
333,-1,0,0q�$	��Top=�$��97��$��30��$��15(�$
��Bold"��� -   $"��allStudentAttendenceListView��$
��Left=�$	��211��$��
60,101,0,0q�$	��Top=�$	��518��   alternatingListViewItemStyle#��[ 
 �� View
 ��  �� AllowsColumnReorder . .P��� $�� �� �� Width$ 0�� �� DisplayMemberBinding �� *Id+�� $��Student Name ��$	 100�� �� *StudentName+�� $��
Department��$	 100�� �� *DepartmentName+�� $��	Semester ��$	 100�� �� *
SemesterNo+�� $��Date ��$	 100�� �� *Date+�� $��Status ��$	 100�� �� *Status+