   M S B A M L   `   `   `  ����   SIPI_SL$    SIPI_SL.UI.Admission.ProgramUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  	ProgramUI��$��456.865��$��726.867��   	GrayWhite#��[   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.��� $��0,6,2,4q�.+��� $��Department Name��$
��Left=�$��
195,62,0,0q�$	��Top=��� $��Program Name��$
��Left=�$��195,100,0,0q�$	��Top=��� -    ��Name$ programNameTextBox��$
��Left=�$��23��$��318,100,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��120���� $��Program Code��$
��Left=�$��195,129,0,0q�$	��Top=��� -   $ programCodeTextBox��$
��Left=�$��23��$��318,131,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��120���� $��Program In Bangla��$
��Left=�$��195,164,0,0q�$	��Top=��� -   $ banglaProgramTextBox��$
��Left=�$��23��$��318,166,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��120���� $��GroupBox��$��
51,208,0,0q�$	��Top=�$	��188��$
��Left=�$	��643��.��� $	��117��$	��Top=�$��	10,48,0,0q�$
��Left=�$	��621��.+��� -   $��programlistView��$	��156��$
��Left=�$��
10,-39,0,0q�$	��Top=�$	��600��   alternatingListViewItemStyle#��[  �� AlternationCount$ 2�� � ContextMenu �� -   $��
proramList�� �� 	StaysOpen . 
������� J� BitmapEffect �� .@�m� -   $��EditProgramContextMenu��$
��Edit��m� -   $��RemoveProgramContextMenu��$��Remove��	 �� View	 �� 
 �� AllowsColumnReorder
 . .P��� $�� �� �� Width$ 0�� �� DisplayMemberBinding ��  �� Path$ Id��� $��Department Name��$	 200�� �� $ DeparimentName��� $��Program Name��$	 200�� �� $ ProgramName��� $��Program Code��$	 200�� �� $ ProgramCode��� $��Bangla Program��$	 100�� �� $ BanglaProgram��� -   $��
saveButton��$
��Save��$
��Left=�$��489,150,0,0q�$	��Top=�$��99�� J� RenderTransformOrigin$ 
0.382,2.52&�$��40���� -	   $��departmentCombobax��$
��Left=�$��
318,62,0,0q�$	��Top=�$	��120��  ComboBoxBGYellowGreen#��[ ���� .R���  �� Orientation$ 
Horizontal=�.+��� $��60������ *DepartmentCode+�� $��|���� $��60������ *DepartmentName+