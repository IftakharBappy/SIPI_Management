   M S B A M L   `   `   `  ����   SIPI_SL#    SIPI_SL.UI.Fees.StudentListUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     a
extToolkitJhttp://schemas.microsoft.com/winfx/2006/xaml/presentation/toolkit/extended       � Title$  Student List UI��$��568.693��$��1008.893�� � ShowInTaskbar .     	GrayWhite#��[   � WindowStartupLocation$ CenterScreen=�.��� $	��367��$��Bottom=�$��0,0,-8,0q� � ColumnDefinitions �� $
��308* ��� $
��424* ��� $
��277* �.+�� $��3�� �� $
��293* ��� $
��716* �.+��� -   $��studentNameTextbox��$��35��$��15(� J� SnapsToDevicePixels .   �� SelectionBrush �	#FF5677B1$��28,-140,714,472q�$��2���� -   $��departmentTextbox��$��15(� .   �	#FF5677B1$��7,-140,474,473q�$��34��$��1���� -   $��studentIdTextbox��$��15(� .   �	#FF5677B1$��285,-140,196,473q�$��34��$��1���� -   $��SearchButton��$��Search��$
��Left=�$��537,-142,0,0q�$	��Top=�$��86��$��32�� J� RenderTransformOrigin$ 3.221,-0.219&�$��1��� $��
0,10,27,10q�$��Right=�$	��763��$��3��.+��� -   $��studentInofListView��$��-190,-104,0,0q�$	��441��$	��Top=�$��Right=�$	��953��   alternatingListViewItemStyle#��[  �� AlternationCount$ 2�� �� View �� 	 �� AllowsColumnReorder	 . .P��� $	��S.L��
 �� Width$
 30�� �� DisplayMemberBinding ��  �� Path$ Id��� $��
Student Id��$	
 100�� �� $ 	StudentID��� $��Student Name��$	
 350�� �� $ ApplicantName��� $��Student Mobile��$	
 200�� �� $ DepartmentName��� $��Campus��$	
 230�� �� $ 
CampusName�