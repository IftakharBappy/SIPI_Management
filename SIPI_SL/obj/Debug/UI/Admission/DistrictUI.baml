   M S B A M L   `   `   `  ����  SIPI_SL%    SIPI_SL.UI.Admission.DistrictUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  District UI��5   	   $	��426��6   $	��525��6*      	GrayWhite#��[  66    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6t   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5
   
   �� $��District Name��6   $
��Left=�6(   $��	47,73,0,0q�6C   $	��Top=�6V   $��26��6n   $	��102��6z   �� 5   
   -   5        $��districtNameTextBox��5   �   $
��Left=�6   $��23��6-   $��
170,76,0,0q�69    �� TextWrapping$
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��120��6�   6�   �� 5   
   $��GroupBox��6   $
��Left=�6%   $��
40,176,0,0q�6@   $	��Top=�6T   $	��184��6l   $	��436��6y   .��5      � $
��Left=�6   $	��162��6.   $	��Top=�6;   $	��426��6S   $��0,0,-2,0q�6_    5      �� 5      $��2* �6'   �� 5      $
��211* �6'   .+�5      �� -   5        $��DistrictlistView��5      $	��156��5      $
��Left=�5      $��2.269,6,0,0q�5      $	��Top=�5      $	��400��5      $��1��6%      alternatingListViewItemStyle#��[ 5       �� AlternationCount$ 2��6^    � ContextMenu 5      �� 5      -   5        $��ZoneIformationList��5   &    �� 	StaysOpen . 
������� J� BitmapEffect 5      �� 5   "   .@�5       m� -   5        $��EditDistrictContextMenu��5    5   $
��Edit��6'   6V   m� 5!      -   5        $��RemoveDistrictContextMenu��5!   7   $��Remove��6'   6Y   5"      	 �� View	 5$      �� 5%      
 �� AllowsColumnReorder
 . .P�5&      �� $�� ��6V    �� Width$ 0��6`    �� DisplayMemberBinding 6-   ��  �� Path$ Id�6`   �� 5'      $��District Name��6`   $	 200��6w    6-   �� $ DistrictName�6w   �� 5(      $��District In Bnagla��6b   $	 200��6~    6-   �� $ BanglaDistrict�6~   5*      5,      5-      5.      �� 5/   
   -   5        $��submitButton��5/   s   $
��Save��6   $
��Left=�6    $��312,114,0,0q�6;   $	��Top=�6P   $��75��6h   $��22��6�   �� 50   
   $��DistrictIn Bangla��6   $
��Left=�6,   $��
47,110,0,0q�6G   $	��Top=�6[   $��26��6s   $	��102��6   �� 51   
   -   5         ��Name$ banglaDistrictTextBox��51   �   $
��Left=�6   $��23��6-   $��170,113,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   6�   53      54      