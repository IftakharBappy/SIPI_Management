   M S B A M L   `   `   `  ����   SIPI_SL7    1SIPI_SL.Report.UI.CourseManagement.CourseReportUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Course Report��$��353.356��$��621.197��   	GrayWhite#��[   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.��� .+�� .+��� -   $��previewReportButton��$��Preview��$
��Left=�$	��Top=�$��75��$��
514,35,0,0q�$��24���� -   $��searchButton��$��Search��$
��Left=�$	��Top=�$��75��$��
433,35,0,0q�$��24���� -   $��departmentCombobox�� �� 
IsEditable .  w� TextPath$ SIPI_DepartmentName��$
��Left=�$��	51,35,0,0q�$	��Top=�$	��238�� J� RenderTransformOrigin$ 0.037,0.146&�$��33������ .R���  �� Orientation$ 
Horizontal=�.+��� $	��238������ *SIPI_DepartmentName+�� -    ��Name$ semesterCombobox�� . $ 
SemesterNo��$
��Left=�$��
294,34,0,0q�$	��Top=�$	��123��$ 0.037,0.146&�$��34������ .R��� $ 
Horizontal=�.+��� $	��130������ *
SemesterNo+�� $��
Department��$
��Left=�$��51,0,0,0q�$	��Top=�$	��164��$��30��$��15(�$
��Bold"��� $��Semester��$
��Left=�$��
294,-1,0,0q�$	��Top=�$	��123��$��30��$��15(�$
��Bold"��� $��All Courses��$
��Left=�$��	55,86,0,0q�$	��Top=�$	��185��$	��520��.��� $
��Left=�$	��162��$	��Top=�$	��518�� � ColumnDefinitions �� $��2* ��� $
��211* �.+��� -   $��courselistView��$	��156��$��2,6,0,0q�$	��Top=�$��1��$
��Left=�$	��501��   alternatingListViewItemStyle#��[ 	 �� View	 �� 
 �� AllowsColumnReorder
 . .P��� $�� �� �� Width$ 0�� �� DisplayMemberBinding ��  �� Path$ Id��� $��Program Name��$	 100�� �� $ ProgramName��� $��Department Name��$	 100�� �� $ DepartmentName��� $��semester��$	 100�� �� $ 
SemesterNo��� $��Course Name��$	 100�� �� $ 
CourseName��� $��Bangla Course��$	 100�� �� $ BanglaCourseName�