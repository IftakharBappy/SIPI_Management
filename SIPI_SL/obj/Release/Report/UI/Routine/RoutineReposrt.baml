   M S B A M L   `   `   `  ����   SIPI_SL.    (SIPI_SL.Report.UI.Routine.RoutineReposrt   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     a
extToolkitJhttp://schemas.microsoft.com/winfx/2006/xaml/presentation/toolkit/extended       � Title$  Routine Report��$��359.356��$��621.197��   	GrayWhite#��[   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.��� .+�� .+��� -   $��yearTextBox��$�� ��$��15(� J� SnapsToDevicePixels .   �� SelectionBrush �	#FF5677B1$��
336,33,0,0q�$��35��$	��Top=�$
��Left=�$��92���� -   $��previewReportButton��$��Preview��$
��Left=�$	��Top=�$��75��$��
514,35,0,0q�$��24���� -   $��searchButton��$��Search��$
��Left=�$	��Top=�$��75��$��
433,35,0,0q�$��24���� $��
Department��$
��Left=�$��51,0,0,0q�$	��Top=�$	��152��$��30��$��15(�$
��Bold"��� $��Semester��$
��Left=�$��	210,0,0,0q�$	��Top=�$	��123��$��30��$��15(�$
��Bold"��� -   $��departmentCombobox�� �� 
IsEditable .  w� TextPath$ SIPI_DepartmentName��$
��Left=�$��	51,35,0,0q�$	��Top=�$	��152�� J� RenderTransformOrigin$ 0.037,0.146&�$��33������ .R���  �� Orientation$ 
Horizontal=�.+��� $	��130������ *SIPI_DepartmentName+�� -   	 ��Name$	 semesterCombobox�� . $ 
SemesterNo��$
��Left=�$��
208,34,0,0q�$	��Top=�$	��123��$ 0.037,0.146&�$��34������ .R��� $ 
Horizontal=�.+��� $	��130������ *
SemesterNo+�� $
��Year��$
��Left=�$��	336,0,0,0q�$	��Top=�$��92��$��30��$��15(�$
��Bold"��� -   $��allRoutineListView��$
��Left=�$	��211��$��	49,77,0,0q�$	��Top=�$	��518��   alternatingListViewItemStyle#��[ 
 �� View
 ��  �� AllowsColumnReorder . .P��� $�� �� �� Width$ 0�� �� DisplayMemberBinding �� *Id+�� $��
Department��$	 100�� �� *DepartmentName+�� $��	Semester ��$	 100�� �� *
SemesterNo+�� $
��Day ��$	 100�� �� *Day+�� $��Firstclass ��$	 100�� �� *FirstClassName+�� $��Last Class ��$	 100�� �� *FirstCourseName+�� $��Year ��$	 100�� �� *Year+�� -    ��Name$$ previewReportButton_department��$��Department Wise Routine��$
��Left=�$	��Top=�$	��166��$��437,293,0,0q�$��24��