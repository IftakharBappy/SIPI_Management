   M S B A M L   `   `   `  ����   SIPI_SL0    *SIPI_SL.UI.TeacherManagement.TeacherInfoUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Teacher Information��$��455.948��$��676.021�� � WindowStartupLocation$ CenterScreen=�   	GrayWhite#��[   � ShowInTaskbar .  .��� .+��� $
��Bold"�$��Teacher Name:��$
��Left=�$��	11,36,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.497,1.192&��� -    ��Name$ txtTeacherName��$
��Left=�$��32��$��
105,30,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��208���� $
��Bold"�$��Department:��$
��Left=�$��	11,67,0,0q�$	��Top=�$ 0.621,1.453&��� -    ��Name$ depertmentComboBox��$
��Left=�$��
105,67,0,0q�$	��Top=�$	��208��  ComboBoxBGYellowGreen#��[ ���� .R���  �� Orientation$ 
Horizontal=�.+��� ���� *SIPI_DepartmentName+.@��� $	��100��$	��120���� -   $��teacherInfoListView��$
��Left=�$	��207��$��105,145,0,0q�$	��Top=�$	��517��   alternatingListViewItemStyle#��[  � ContextMenu �� -   $��lstTeacherInfo��	 �� 	StaysOpen	 . 
�������
 J� BitmapEffect
 �� .@�m� -   $��EditProgramContexMenu��$
��Edit��m� -   $��RemoveProgramContexMenu��$��Rmove�� �� View ��  �� AllowsColumnReorder . .P��� $�� �� �� Width$ 0�� �� DisplayMemberBinding ��  �� Path$ Id��� $��Teacher Name��$	 220�� �� $ TeacherName��� $��
Department��$	 180�� �� $ DepartmentName��� $��Campus��$	 150�� �� $ 
CampusName��� -    ��Name$ btnSave��$
��Save��$
��Left=�$��
507,82,0,0q�$	��Top=�$	��115��$��34��$
��Bold"��� -   $ clearButton��$��Clear��$
��Left=�$��
387,82,0,0q�$	��Top=�$	��115��$
��Bold"�$��34���� $
��Bold"�$��Campus:��$
��Left=�$��
338,30,0,0q�$	��Top=�$ 0.621,1.453&��� -	   $ courseComboBox��$
��Left=�$��
414,30,0,0q�$	��Top=�$	��208��#��[ ���� .R��� $ 
Horizontal=�.+��� ���� *
CampusName+.@��� $	��100��$	��120��