   M S B A M L   `   `   `  ����   SIPI_SL0    *SIPI_SL.UI.StudentManagement.ClassPeriodUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Class Period��$��365.945��$��601.393��   	GrayWhite#��[   � ShowInTaskbar .  .��� $��0,0,0,-8q�.+��� $��Insert Period Name:��$
��Left=�$��	83,73,0,0q�$	��Top=��� -    ��Name$ txtPeriodName��$
��Left=�$��23��$��
203,76,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��172���� $��Start Time:��$
��Left=�$��
83,104,0,0q�$	��Top=��� -   $ txtStartTime��$
��Left=�$��23��$��203,107,0,0q�$
 Wrap=�$	��Top=�$	��172���� $��	End Time:��$
��Left=�$��
83,135,0,0q�$	��Top=��� -   $ 
txtEndTime��$
��Left=�$��23��$��203,138,0,0q�$
 Wrap=�$	��Top=�$	��172���� $��Class Period Setup��$
��Left=�$��
166,10,0,0q�$	��Top=����	#FF02A3D3$��Lucida Calligraphy)�$��22(�$��Italic$��� -    ��Name$ btnNew��$	��New��$
��Left=�$��26��$��
401,73,0,0q�$	��Top=�$	��100���� -   $��btnSave��$
��Save��$
��Left=�$��26��$��401,104,0,0q�$	��Top=�$	��100���� -   $ btnClase��$��Close��$
��Left=�$��26��$��401,135,0,0q�$	��Top=�$	��100���� -   $��ClassPeriodListView��$
��Left=�$	��144��$��
83,178,0,0q�$	��Top=�$	��429�� � ContextMenu �� -   $��lstClassPeriod�� �� 	StaysOpen . 
������� J� BitmapEffect �� .@�m� -	   $��EditProgramContexMenu��$
��Edit��m� -
   $��RemoveProgramContexMenu��$��Rmove�� �� View �� 	 �� AllowsColumnReorder	 . .P��� $�� ��
 �� Width$
 0�� �� DisplayMemberBinding ��  �� Path$ Id��� $��Period��$	
 130�� �� $ 
PeriodName��� $��
Start Time��$	
 130�� �� $ 	StartTime��� $��End Time��$	
 130�� �� $ EndTime�