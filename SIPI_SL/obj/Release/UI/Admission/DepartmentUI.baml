   M S B A M L   `   `   `  ����   SIPI_SL'    !SIPI_SL.UI.Admission.DepartmentUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Department UI��$	��426��$	��525��   	GrayWhite#��[   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� �� $��0* �.+��� $��Department Nme��$
��Left=�$��	47,73,0,0q�$	��Top=�$��26��$	��102���� -   $��departmentNameTextBox��$
��Left=�$��23��$��
186,76,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��120���� $��Department Code��$
��Left=�$��
47,111,0,0q�$	��Top=�$��26��$	��105���� -   $��departmentCodeTextBox��$
��Left=�$��23��$��186,113,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��120���� $��GroupBox��$
��Left=�$��
40,176,0,0q�$	��Top=�$	��184��$	��436��.��� $
��Left=�$	��162��$	��Top=�$	��426��$��0,0,-2,0q� �� $��2* ��� $
��211* �.+��� -   $��departmentlistView��$	��156��$
��Left=�$��12,6,0,0q�$	��Top=�$	��400��$��1��   alternatingListViewItemStyle#��[  �� AlternationCount$ 2�� � ContextMenu �� -   $��ZoneIformationList�� �� 	StaysOpen . 
������� J� BitmapEffect �� .@�m� -   $��EditDepartmentContextMenu��$
��Edit��m� -   $!��RemoveDepartmentContextMenu��$��Remove��	 �� View	 �� 
 �� AllowsColumnReorder
 . .P��� $�� �� �� Width$ 0�� �� DisplayMemberBinding ��  �� Path$ Id��� $��Department Name��$	 200�� �� $ DepartmentName��� $
��Code��$	 100�� �� $ DepartmentCode��� $��Bangla Department Name��$	 100�� �� $ BanglaDepartment��� -   $��submitButton��$
��Save��$
��Left=�$��348,150,0,0q�$	��Top=�$��75��$��22���� $��Department In Bangla��$
��Left=�$��
47,146,0,0q�$	��Top=�$��26��$	��140���� -    ��Name$ banglaDepartmentTextBox��$
��Left=�$��23��$��186,148,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��120��