   M S B A M L   `   `   `  ����   SIPI_SL'    !SIPI_SL.UI.Admission.BloodGroupUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Blood Group UI��$��337.363��$��353.846��   	GrayWhite#��[   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.��� $��0,0,0,-2q�.+��� $��Blood Group��$
��Left=�$��	27,10,0,0q�$	��Top=�$	��119��$	��294��.��� .+��� $��Blood Group��$
��Left=�$��35��$	��Top=�$��80��$��	10,10,0,0q��� -   $��bloodGroupTextBox��$��114,10,10,0q�$��28��$	��Top=��� -   $��submitButton��$��131,57,10,0q�$
��Save��$��28��$	��Top=� J� RenderTransformOrigin$ 
0.909,2.21&��� $��Blood Group��$
��Left=�$��
27,134,0,0q�$	��Top=�$	��156��$	��294��.��� $
��Left=�$	��127��$	��Top=�$	��284��$��0,0,-2,0q� � ColumnDefinitions �� $��2* ��� $
��211* �.+��� -   $��bloodGroupListView��$	��107��$��	10,10,0,0q�$	��Top=�$��1��$
��Left=�$	��261��   alternatingListViewItemStyle#��[  �� AlternationCount$ 2�� � ContextMenu �� -   $��ZoneIformationList�� �� 	StaysOpen . 
������� J� BitmapEffect �� .@�m� -   $��EditBloodGroupContextMenu��$
��Edit��m� -   $!��RemoveBloodGroupContextMenu��$��Remove��	 �� View	 �� 
 �� AllowsColumnReorder
 . .P��� $�� �� �� Width$ 0�� �� DisplayMemberBinding ��  �� Path$ Id��� $��Blood Group��$	 300�� �� $ BloodGroupName�