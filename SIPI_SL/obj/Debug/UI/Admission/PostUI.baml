   M S B A M L   `   `   `  ����  SIPI_SL!    SIPI_SL.UI.Admission.PostUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Post UI��5   	   $��391.209��6   $��478.022��6*      	GrayWhite#��[  6:    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6x   .��5      �  � RowDefinitions 5   
   �� 5      .+�5	   
   �� $��
Thana Name��6   $
��Left=�6%   $��	24,48,0,0q�6@   $	��Top=�6S   $��26��6k   $	��102��6w   �� 5
   
   -   5         ��Name$ postNameTextBox��5
   �   $
��Left=�6   $��25��6-   $��
143,82,0,0q�69    �� TextWrapping$
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��159��6�   6�   �� 5   
   $��	Post Name��6   $
��Left=�6$   $��	24,81,0,0q�6?   $	��Top=�6R   $��26��6j   $	��102��6v   �� 5   
   -   5        $ postCodeTextBox��5   �   $
��Left=�6   $��24��6-   $��143,110,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��159��6�   6�   �� 5   
   $��	Post Code��6   $
��Left=�6$   $��
24,107,0,0q�6?   $	��Top=�6S   $��26��6k   $	��102��6w   �� 5   
   -   5        $ banglaPostNameTextBox��5   �   $
��Left=�6   $��24��6-   $��143,138,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��159��6�   6�   �� 5   
   $��Post in Bnangla��6   $
��Left=�6*   $��
24,133,0,0q�6E   $	��Top=�6Y   $��34��6q   $	��102��6}   �� 5   
   $��GroupBox��6   $
��Left=�6%   $��
10,167,0,0q�6@   $	��Top=�6T   $	��184��6l   $	��436��6y   $��2��6�   .��5      � $
��Left=�6   $	��162��6.   $	��Top=�6;   $	��426��6S   $��0,0,-2,0q�6_    � ColumnDefinitions 5      �� 5      $��2* �6'   �� 5      $
��211* �6'   .+�5      �� -   5         ��Name$ postlistView��5   	   $	��156��5      $
��Left=�5   	   $��2,6,0,0q�5   	   $	��Top=�5   	   $	��420��5   	   $��1��6      alternatingListViewItemStyle#��[ 5       �� AlternationCount$ 2��6^   	 � ContextMenu	 5      �� 5       -   5        
 ��Name$
 ZoneIformationList��5    &    �� 	StaysOpen . 
������� J� BitmapEffect 5!      �� 5"   "   .@�5$      m� -   5         m�Name$ EditThanaContextMenu��5$   5   $
��Edit��6'   6U   m� 5%      -   5        $ RemoveThanaContextMenu��5%   7   $��Remove��6'   6X   5&       �� View 5(      �� 5)       �� AllowsColumnReorder . .P�5*      �� $�� ��6Q    �� Width$ 0��6[    �� DisplayMemberBinding 6-   �� *Id+6[   �� 5+      $��	Post Name��6W   $	 100��6j    6-   �� *
PostName+6j   �� 5,      $��	Post Code��6W   $	 100��6j    6-   �� *
PostCode+6j   �� 5-      $��Post In Bangla��6]   $	 100��6u    6-   �� *BanglaPostName+6u   �� 5.      $��District Name��6[   $	 100��6r    6-   �� *DistrictName+6r   �� 5/      $��
Thana Name��6X   $	 100��6l    6-   �� *	ThanaName+6l   50      52      53      54      �� 55   
   -   5         ��Name$ submitButton��55   s   $
��Save��6   $
��Left=�6    $��314,103,0,0q�6;   $	��Top=�6P   $��75��6h   $��22��6�   �� 56   
   $��District Name��6   $��24,17,364,0q�6(   $	��Top=�6=   �� 57   
   -	   5         ��Name$ districtCombobax��5<       �� 
IsEditable .  w� TextPath$ DistrictName��59      $��143,12,168,0q�5:      $	��Top=�5;        ComboBoxBGYellowGreen#��[ 5>      $
��Auto��6<   ��5?      �� 5@      .R�5A      ��  �� Orientation$ 
Horizontal=�6!   .+�5B      �� $��60��6B   ��6$   �� *DistrictName+6B   5D      5E      5G      �� 5H   
   -
   5        $ thanaCombobax��5L       . $ 	ThanaName��5J      $��143,47,168,0q�6-   $	��Top=�5K      #��[ 5L   %   $
��Auto��6T   ��5M      �� 5N      .R�5O      �� $ 
Horizontal=�6!   .+�5P      �� $��60��6?   ��6$   �� *	ThanaName+6?   5Q      5R      5T      5W      5X      