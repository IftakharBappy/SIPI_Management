   M S B A M L   `   `   `  ����  SIPI_SL"    SIPI_SL.UI.Admission.ThanaUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Thana UI��5      $	��426��6   $	��525��6&      	GrayWhite#��[  62    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6p   .��5      �  � ColumnDefinitions 5   
   �� 5      .+�5	   
   �� $��
Thana Name��6   $
��Left=�6%   $��	49,90,0,0q�6@   $	��Top=�6S   $��26��6k   $	��102��6w   �� 5
   
   -   5        $��ThanaNameTextBox��5
   �   $
��Left=�6   $��23��6-   $��
172,93,0,0q�69    �� TextWrapping$
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��120��6�   6�   �� 5   
   $��Thana In Bangla��6   $
��Left=�6*   $��
49,118,0,0q�6E   $	��Top=�6Y   $��26��6q   $	��102��6}   �� 5   
   -   5        $��banglaThanaNameTextBox��5   �   $
��Left=�6   $��23��6-   $��172,121,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   6�   �� 5   
   $��GroupBox��6   $
��Left=�6%   $��
40,176,0,0q�6@   $	��Top=�6T   $	��184��6l   $	��424��6y   .��5      � $
��Left=�6   $	��162��6.   $	��Top=�6;   $	��426��6S   $��0,0,-2,0q�6_    5      �� 5      $��2* �6'   �� 5      $
��211* �6'   .+�5      �� -   5        $��ThanalistView��5      $	��156��5      $
��Left=�5      $��2.269,6,0,0q�5      $	��Top=�5      $	��400��5      $��1��6%      alternatingListViewItemStyle#��[ 5       �� AlternationCount$ 2��6\    � ContextMenu 5      �� 5      -   5        $��ZoneIformationList��5   &    �� 	StaysOpen . 
������� J� BitmapEffect 5      �� 5    "   .@�5"      m� -   5        $��EditThanaContextMenu��5"   5   $
��Edit��6'   6S   m� 5#      -   5        $��RemoveThanaContextMenu��5#   7   $��Remove��6'   6V   5$      	 �� View	 5&      �� 5'      
 �� AllowsColumnReorder
 . .P�5(      �� $�� ��6V    �� Width$ 0��6`    �� DisplayMemberBinding 6-   ��  �� Path$ Id�6`   �� 5)      $�� ��6^   $ 0��6h    6-   �� $ 
DistrictId�6h   �� 5*      $��District Name��6`   $	 100��6w    6-   �� $ DistrictName�6w   �� 5+      $��
Thana Name��6]   $	 150��6q    6-   �� $ 	ThanaName�6q   �� 5,      $��Thana In Bangla��6c   $	 150��6|    6-   �� $ BanglaThanaName�6|   5.      50      51      52      �� 53   
   -   5        $��submitButton��53   s   $
��Save��6   $
��Left=�6    $��343,149,0,0q�6;   $	��Top=�6P   $��75��6h   $��22��6�   �� 54   
   $��District Name��6   $
��Left=�6(   $��	49,56,0,0q�6C   $	��Top=�6V   $��26��6n   $��82��6z   �� 55   
   -   5         ��Name$ districtCombobax��55   f   $
��Left=�6   $��
172,56,0,0q�6.   $	��Top=�6B   $	��120��6Z   $��22��6�     ComboBoxBGYellowGreen#��[ 6�   ��56      �� 57      .R�58      ��  �� Orientation$ 
Horizontal=�6!   .+�59      �� $��60��6B   ��6$   �� *DistrictName+6B   5<      5=      5?      5B      5C      