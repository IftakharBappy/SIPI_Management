   M S B A M L   `   `   `  ����   SIPI_SL+    %SIPI_SL.UI.Admission.AdmissonOfficeUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Admission Office UI��$��332.968��$��462.637�� � ShowInTaskbar .   � 
ResizeMode$ CanMinimize=� � WindowStartupLocation$ CenterScreen=�   	GrayWhite#��[  .��� .+��� $��Office name��$
��Left=�$��17,7,0,0q�$	��Top=�$��26��$	��102���� -    ��Name$ officeNameTextBox��$
��Left=�$��23��$��
140,10,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��120���� $��Office Address��$
��Left=�$��	17,45,0,0q�$	��Top=�$��26��$	��105���� $��Admission Office��$
��Left=�$��10,110,-154,-24q�$	��Top=�$	��184��$	��436��.��� $
��Left=�$	��162��$	��Top=�$	��426��$��0,0,-2,0q�.+��� -   $��admissionOfficeView��$	��156��$
��Left=�$��4,2,0,0q�$	��Top=�$	��416��   alternatingListViewItemStyle#��[  �� AlternationCount$ 2�� � ContextMenu �� -   $��admissionOffice�� �� 	StaysOpen . 
�������	 J� BitmapEffect	 �� .@�m� -   $��EditProgramContextMenu��$
��Edit��m� -   $��RemoveProgramContextMenu��$��Remove��
 �� View
 ��  �� AllowsColumnReorder . .P��� $�� �� �� Width$ 0�� �� DisplayMemberBinding ��  �� Path$ Id��� $��Office Name��$	 200�� �� $ 
OfficeName��� $��Office Address��$	 200�� �� $ OfficeAddress��� -    ��Name$ submitButton��$
��Save��$
��Left=�$��282,48,-65,0q�$	��Top=�$��75��$��22���� -    ��Name$ campusCombobax��$
��Left=�$��
140,49,0,0q�$	��Top=�$	��120��  ComboBoxBGYellowGreen#��[ ���� .R���  �� Orientation$ 
Horizontal=�.+��� $��60������ *
CampusName+