   M S B A M L   `   `   `  ����  SIPI_SL0    *SIPI_SL.UI.TeacherManagement.TeacherInfoUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Teacher Information��5   	   $��455.948��6%   $��676.021��66    � WindowStartupLocation$ CenterScreen=�6F      	GrayWhite#��[  6k    � ShowInTaskbar .  .��5      � .+�5   
   �� $
��Bold"�6   $��Teacher Name:��6"   $
��Left=�6:   $��	11,36,0,0q�6U   $	��Top=�6h    J� RenderTransformOrigin$ 0.497,1.192&�6�   �� 5   
   -   5         ��Name$ txtTeacherName��5      $
��Left=�6*   $��32��6E   $��
105,30,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��208��6�   6�   �� 5   
   $
��Bold"�6   $��Department:��6"   $
��Left=�68   $��	11,67,0,0q�6S   $	��Top=�6f   $ 0.621,1.453&�6~   �� 5	   
   -   5         ��Name$ depertmentComboBox��5	   �   $
��Left=�6   $��
105,67,0,0q�6.   $	��Top=�6B   $	��208��6Z     ComboBoxBGYellowGreen#��[ 6f   ��5
      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6$   �� *SIPI_DepartmentName+5      5      .@�5      �� $	��100��6   $	��120��6$   5      �� 5   
   -   5        $��teacherInfoListView��5      $
��Left=�5      $	��207��5      $��105,145,0,0q�5      $	��Top=�5      $	��517��5         alternatingListViewItemStyle#��[ 5   f    � ContextMenu 5      �� 5      -   5        $��lstTeacherInfo��5      	 �� 	StaysOpen	 . 
�������
 J� BitmapEffect
 5      �� 5       .@�5"      m� -   5        $��EditProgramContexMenu��5"   -   $
��Edit��6   6J   m� 5#      -   5        $��RemoveProgramContexMenu��5#   .   $��Rmove��6   6M   5$       �� View 5&      �� 5'       �� AllowsColumnReorder . .P�5(      �� $�� ��6N    �� Width$ 0��6X    �� DisplayMemberBinding 6%   ��  �� Path$ Id�6X   �� 5)      $��Teacher Name��6W   $	 220��6m    6%   �� $ TeacherName�6m   �� 5*      $��
Department��6Z   $	 180��6n    6%   �� $ DepartmentName�6n   �� 5+      $��Campus��6V   $	 150��6f    6%   �� $ 
CampusName�6f   5-      5/      �� 50   
   -   5         ��Name$ btnSave��50      $
��Save��6"   $
��Left=�61   $��
507,82,0,0q�6L   $	��Top=�6`   $	��115��6x   $��34��6�   $
��Bold"�6�   �� 51   
   -   5        $ clearButton��51      $��Clear��6&   $
��Left=�66   $��
387,82,0,0q�6Q   $	��Top=�6e   $	��115��6}   $
��Bold"�6�   $��34��6�   �� 52   
   $
��Bold"�6   $��Campus:��6"   $
��Left=�64   $��
338,30,0,0q�6O   $	��Top=�6c   $ 0.621,1.453&�6{   �� 53   
   -	   5        $ courseComboBox��53   �   $
��Left=�6   $��
414,30,0,0q�6.   $	��Top=�6B   $	��208��6Z   #��[ 6f   ��54      �� 55      .R�56      �� $ 
Horizontal=�6!   .+�57      �� ��6$   �� *
CampusName+5;      5<      .@�5>      �� $	��100��6   $	��120��6$   5?      5@      5A      