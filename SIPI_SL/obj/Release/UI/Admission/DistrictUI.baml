   M S B A M L   `   `   `  ����   SIPI_SL%    SIPI_SL.UI.Admission.DistrictUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  District UI��$	��426��$	��525��   	GrayWhite#��[   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� �� $��0* �.+��� $��District Name��$
��Left=�$��	47,73,0,0q�$	��Top=�$��26��$	��102���� -   $��districtNameTextBox��$
��Left=�$��23��$��
170,76,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��120���� $��GroupBox��$
��Left=�$��
40,176,0,0q�$	��Top=�$	��184��$	��436��.��� $
��Left=�$	��162��$	��Top=�$	��426��$��0,0,-2,0q� �� $��2* ��� $
��211* �.+��� -   $��DistrictlistView��$	��156��$
��Left=�$��2.269,6,0,0q�$	��Top=�$	��400��$��1��   alternatingListViewItemStyle#��[  �� AlternationCount$ 2�� � ContextMenu �� -   $��ZoneIformationList�� �� 	StaysOpen . 
������� J� BitmapEffect �� .@�m� -   $��EditDistrictContextMenu��$
��Edit��m� -   $��RemoveDistrictContextMenu��$��Remove��	 �� View	 �� 
 �� AllowsColumnReorder
 . .P��� $�� �� �� Width$ 0�� �� DisplayMemberBinding ��  �� Path$ Id��� $��District Name��$	 200�� �� $ DistrictName��� $��District In Bnagla��$	 200�� �� $ BanglaDistrict��� -   $��submitButton��$
��Save��$
��Left=�$��312,114,0,0q�$	��Top=�$��75��$��22���� $��DistrictIn Bangla��$
��Left=�$��
47,110,0,0q�$	��Top=�$��26��$	��102���� -    ��Name$ banglaDistrictTextBox��$
��Left=�$��23��$��170,113,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��120��