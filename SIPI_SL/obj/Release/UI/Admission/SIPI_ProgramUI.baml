   M S B A M L   `   `   `  ����   SIPI_SL)    #SIPI_SL.UI.Admission.SIPI_ProgramUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
Program UI��$��414.208��$��583.962��   	GrayWhite#��[   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� .+��� $��Program Nme��$
��Left=�$��	47,73,0,0q�$	��Top=�$��26��$	��102���� -   $��SipiProgramNameTextBox��$
��Left=�$��23��$��
186,76,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��120���� $��Duration Time��$
��Left=�$��
47,102,0,0q�$	��Top=�$��26��$	��105���� $
��Year��$
��Left=�$��318,103,0,0q�$	��Top=�$��26��$��45���� -   $��SipiProgramTimeTextBox��$
��Left=�$��23��$��186,104,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��120���� $��GroupBox��$
��Left=�$��
40,176,0,0q�$	��Top=�$	��197��$	��464��.��� $
��Left=�$	��162��$	��Top=�$	��426��$��0,0,-2,0q� �� $��2* ��� $
��211* �.+��� -   $��sIPI_programlistView��$	��156��$
��Left=�$��	2,6,-12,0q�$	��Top=�$	��432��$��1��   alternatingListViewItemStyle#��[  �� AlternationCount$ 2�� � ContextMenu �� -   $��ZoneIformationList�� �� 	StaysOpen . 
������� J� BitmapEffect �� .@�m� -   $��EditDepartmentContextMenu��$
��Edit��m� -   $!��RemoveDepartmentContextMenu��$��Remove��	 �� View	 �� 
 �� AllowsColumnReorder
 . .P��� $�� �� �� Width$ 0�� �� DisplayMemberBinding ��  �� Path$ Id��� $��Program Name��$	 200�� �� $ SIPI_ProgramName��� $��Duration Time��$	 100�� �� $ SIPI_ProgramTime��� $��Bangla Program Name��$	 100�� �� $ BanglaSIPI_ProgramName��� -   $��submitButton��$
��Save��$
��Left=�$��395,150,0,0q�$	��Top=�$��75��$��22���� $��Program In Bangla��$
��Left=�$��
47,128,0,0q�$	��Top=�$��26��$	��140���� -    ��Name$ banglaSipiProgramTextBox��$
��Left=�$��23��$��186,130,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��120���� -	    ��Name$ clearButton��$��Clear��$
��Left=�$��311,149,0,0q�$	��Top=�$��75��$��22��