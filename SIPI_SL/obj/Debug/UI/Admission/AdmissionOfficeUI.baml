   M S B A M L   `   `   `  ����  SIPI_SL+    %SIPI_SL.UI.Admission.AdmissonOfficeUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Admission Office UI��5   	   $��332.968��6%   $��462.637��66    � ShowInTaskbar .   � 
ResizeMode$ CanMinimize=�6\    � WindowStartupLocation$ CenterScreen=�6u      	GrayWhite#��[  6�   .��5      � .+�5   
   �� $��Office name��6   $
��Left=�6&   $��17,7,0,0q�6A   $	��Top=�6S   $��26��6k   $	��102��6w   �� 5	   
   -   5         ��Name$ officeNameTextBox��5	   �   $
��Left=�6   $��23��6-   $��
140,10,0,0q�69    �� TextWrapping$
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��120��6�   6�   �� 5
   
   $��Office Address��6   $
��Left=�6)   $��	17,45,0,0q�6D   $	��Top=�6W   $��26��6o   $	��105��6{   �� 5   
   $��Admission Office��6   $
��Left=�6-   $��10,110,-154,-24q�6H   $	��Top=�6a   $	��184��6y   $	��436��6�   .��5      � $
��Left=�6   $	��162��6.   $	��Top=�6;   $	��426��6S   $��0,0,-2,0q�6_   .+�5      �� -   5        $��admissionOfficeView��5      $	��156��5      $
��Left=�5      $��4,2,0,0q�5      $	��Top=�5      $	��416��5         alternatingListViewItemStyle#��[ 6%    �� AlternationCount$ 2��6h    � ContextMenu 5      �� 5      -   5        $��admissionOffice��5   &    �� 	StaysOpen . 
�������	 J� BitmapEffect	 5      �� 5   "   .@�5      m� -   5        $��EditProgramContextMenu��5   5   $
��Edit��6'   6S   m� 5      -   5        $��RemoveProgramContextMenu��5   7   $��Remove��6'   6W   5      
 �� View
 5      �� 5       �� AllowsColumnReorder . .P�5      �� $�� ��6V    �� Width$ 0��6`    �� DisplayMemberBinding 6-   ��  �� Path$ Id�6`   �� 5      $��Office Name��6^   $	 200��6s    6-   �� $ 
OfficeName�6s   �� 5       $��Office Address��6a   $	 200��6y    6-   �� $ OfficeAddress�6y   5!      5#      5+      5,      �� 5-   
   -   5         ��Name$ submitButton��5-   t   $
��Save��6   $
��Left=�6    $��282,48,-65,0q�6;   $	��Top=�6Q   $��75��6i   $��22��6�   �� 5.   
   -   5         ��Name$ campusCombobax��5.   f   $
��Left=�6   $��
140,49,0,0q�6.   $	��Top=�6B   $	��120��6Z     ComboBoxBGYellowGreen#��[ 6   ��5/      �� 50      .R�51      ��  �� Orientation$ 
Horizontal=�6!   .+�52      �� $��60��6@   ��6$   �� *
CampusName+6@   56      57      59      5;      5<      