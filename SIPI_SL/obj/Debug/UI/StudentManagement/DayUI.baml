   M S B A M L   `   `   `  ����  SIPI_SL(    "SIPI_SL.UI.StudentManagement.DayUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Day UI��5   	   $	��426��6   $	��525��6%      	GrayWhite#��[  61    � ShowInTaskbar .  .��5      �  � ColumnDefinitions 5   
   .+�5
   
   �� $	��Day��6   $
��Left=�6   $��	49,73,0,0q�69   $	��Top=�6L   $��26��6d   $	��102��6p   �� 5   
   -   5        $��
dayTextBox��5   �   $
��Left=�6   $��32��6-   $��
151,68,0,0q�69    �� TextWrapping$
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��139��6�   6�   �� 5   
   $	��Day��6   $
��Left=�6    $��
40,176,0,0q�6;   $	��Top=�6O   $	��184��6g   $	��250��6t   .��5      � $
��Left=�6   $	��157��6.   $	��Top=�6;   $	��240��6S   $��0,0,-2,0q�6_    5      �� 5      $��2* �6'   �� 5      $
��211* �6'   .+�5      �� -   5        $��daylistView��5      $	��158��5      $
��Left=�5      $��11,0,0,0q�5      $	��Top=�5      $	��213��5      $��1��6%    � ContextMenu 5      �� 5      -   5        $��ZoneIformationList��5   &    �� 	StaysOpen . 
������� J� BitmapEffect 5      �� 5   "   .@�5      m� -   5        $��EditDistrictContextMenu��5   5   $
��Edit��6'   6T   m� 5       -   5        $��RemoveDistrictContextMenu��5    7   $��Remove��6'   6X   5!       �� View 5#      �� 5$       �� AllowsColumnReorder . .P�5%      �� $�� ��6V   	 �� Width$	 0��6`   
 �� DisplayMemberBinding
 6-   ��  �� Path$ Id�6`   �� 5&      $	��Day��6`   $		 100��6m   
 6-   �� $ DaySeveneven�6m   �� 5'      $��Day In Bnagla��6]   $		 100��6t   
 6-   �� $ 	BanglaDay�6t   5)      5+      5,      5-      �� 5.   
   -   5        $��
saveButton��5.   s   $
��Save��6   $
��Left=�6    $��215,149,0,0q�6;   $	��Top=�6P   $��75��6h   $��22��6�   6�   �� 5/   
   $��Day in Bangla��6   $
��Left=�6(   $��
47,110,0,0q�6C   $	��Top=�6W   $��26��6o   $	��102��6{   �� 50   
   -   5         ��Name$ banglaDayTextBox��50   �   $
��Left=�6   $��31��6-   $��151,105,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��139��6�   6�   �� 51   
   $
��Year��6   $
��Left=�6   $��
302,73,0,0q�6:   $	��Top=�6N   $��26��6f   $��80��6r   �� 52   
   -   5        $ YearTextBox��52   �   $
��Left=�6   $��32��6-   $��
387,67,0,0q�69   $
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $��94��6�    J� RenderTransformOrigin$ -0.076,0.44&�6�   �� 53   
   -	   5         ��Name$ saveYearButton��53   x   $��	Save Year��6   $
��Left=�6%   $��406,149,0,0q�6@   $	��Top=�6U   $��75��6m   $��22��6�   6�   �� 54   
   $
��Year��6   $
��Left=�6!   $��302,176,0,0q�6<   $	��Top=�6Q   $	��184��6i   $	��179��6v   .��55      � $
��Left=�6   $	��154��6.   $	��Top=�6;   $	��169��6S   $��0,0,-2,0q�6_    56      �� 57      $��2* �6'   �� 58      $
��211* �6'   .+�5;      �� -
   5         ��Name$ yearlistView��5>      $	��154��5;      $
��Left=�5<      $��11,0,0,0q�5=      $	��Top=�5?      $	��146��5@      $��1��6    5A      �� 5B      -   5         ��Name$ ZoneIformationList1��5B   &    . 
������� 5C      �� 5D   "   .@�5F      m� -   5         m�Name$ RemoveYearContextMenu��5F   7   $��Remove��6'   6V   5G       5I      �� 5J       . .P�5K      �� $�� ��6Q   $	 0��6[   
 6-   �� *Id+6[   �� 5L      $
��Year��6S   $		 150��6a   
 6-   �� *Year+6a   5M      5O      5P      5Q      5S      5T      