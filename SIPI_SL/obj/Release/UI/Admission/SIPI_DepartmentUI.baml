   M S B A M L   `   `   `  ����   SIPI_SL,    &SIPI_SL.UI.Admission.SIPI_DepartmentUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Department UI��$��456.865��$��726.867��   	GrayWhite#��[   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.��� $��	0,6,-8,-5q�.+��� $��-3,0,33,280q�.��� $��0,0,-2,4q�.+��� -   $��sipi_ProgramCombobax��$
��Left=�$��
155,14,0,0q�$	��Top=�$	��161��  ComboBoxBGYellowGreen#��[ ���� .R���  �� Orientation$ 
Horizontal=�.+��� $	��120������ *SIPI_ProgramName+�� $��||���� $��60������ *SIPI_ProgramTime+�� $��Program Name��$
��Left=�$��	27,14,0,0q�$	��Top=��� $��Technology ��$
��Left=�$��	27,48,0,0q�$	��Top=��� $,��&Regulation / প্রবিধান ��$
��Left=�$��
321,14,0,0q�$	��Top=��� $��
Entry Date��$
��Left=�$��
321,38,0,0q�$	��Top=��� -    ��Name$ departmentNameTextBox��$
��Left=�$��23��$��
155,50,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��161���� $��Technology Code��$
��Left=�$��	27,73,0,0q�$	��Top=��� -   $ departmentCodeTextBox��$
��Left=�$��23��$��
155,75,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��161���� $��Technology In Bangla��$
��Left=�$��
27,100,0,0q�$	��Top=��� -   $ bangladepartmentTextBox��$
��Left=�$��23��$��155,102,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��161���� -   $ regulationTextBox��$
��Left=�$��23��$��
467,17,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��120��(  "System.Windows.Controls.DatePicker  -   $#��regulationEntryDateDatePicker��
�������$
��Left=�$��
467,45,0,0q�$	��Top=�$	��120��$��24���� -   $��
saveButton��$
��Save��$
��Left=�$��602,102,0,0q�$	��Top=�$��75��$��23���� -   $��clearButton��$��Clear��$
��Left=�$��512,102,0,0q�$	��Top=�$��75�� J� RenderTransformOrigin$ 0.284,0.634&�$��23���� $��Department Info��$��
51,177,0,0q�$	��Top=�$	��188��$
��Left=�$	��643��.��� $	��117��$	��Top=�$��	10,48,0,0q�$
��Left=�$	��621��.+��� -	   $��sIPIDepartmentListView��$	��156��$
��Left=�$��
10,-39,0,0q�$	��Top=�$	��600��   alternatingListViewItemStyle#��[  �� AlternationCount$ 2�� � ContextMenu �� -
   $��
proramList��	 �� 	StaysOpen	 . 
�������
 J� BitmapEffect
 �� .@�m� -   $#��EditSIPI_DeprtmentContextMenu��$
��Edit��m� -   $%��RemoveSIPI_DeprtmentContextMenu��$��Remove��m� -   $��ViewContextMenu��$
��View�� �� View ��  �� AllowsColumnReorder . .P��� $�� �� �� Width$ 0�� �� DisplayMemberBinding ��  �� Path$ Id��� $��Program Name��$	 200�� �� $ SIPI_ProgramName��� $��Department Name��$	 200�� �� $ SIPI_DepartmentName��� $��Department Code��$	 200�� �� $ SIPI_DepartmentCode��� $��
Regulation��$	 100�� �� $ 
Regulation�