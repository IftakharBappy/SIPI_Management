   M S B A M L   `   `   `  ����  SIPI_SL#    SIPI_SL.UI.Fees.SetupUpFeesUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
Setup Fees��5   	   $��513.03��6   $��774.284��6,    � ShowInTaskbar .   � 
ResizeMode$ CanMinimize=�6S    � WindowStartupLocation$ CenterScreen=�6l      	GrayWhite#��[  6�   .��5      � .+�5   
   �� -   5         ��Name$ label2��5   �   $ ��Department wise Fees Setup��6   $��LeftToRight=�65   $��18(�6Q   $
��Bold"�6_   $��33��6q   $��259,0,244,0q�6}   $	��Top=�6�   $��Center=�6�   $	��265��6�   �� 5   
   -   5         ��Name$ DepartmentComboBox��5   f   $
��Left=�6   $��
123,49,0,0q�6.   $	��Top=�6B   $	��277��6Z     ComboBoxBGYellowGreen#��[ 6�   �� 5   
   $��
Department��6   $
��Left=�6%   $��	45,53,0,0q�6@   $	��Top=�6S   $��89��6k   �� 5	   
   -   5        $ SemesterComboBox��5	   f   $
��Left=�6   $��
474,49,0,0q�6.   $	��Top=�6B   $	��105��6Z   #��[ 6�   �� 5
   
   $��Semester��6   $
��Left=�6#   $��
414,53,0,0q�6>   $	��Top=�6R   $	��124��6j   �� 5   
   -   5        $ YearComboBox��5   e   $
��Left=�6   $��
628,49,0,0q�6.   $	��Top=�6B   $��95��6Z   #��[ 6|   �� 5   
   $
��Year��6   $
��Left=�6   $��
584,53,0,0q�6:   $	��Top=�6N   $��44��6f   &   System.Windows.Controls.DataGrid  5   
   -   5        $��setupFeesDataGrid��5   !      AutoGenerateColumns .  $	��254��5      $
��Left=�6   $��
43,145,0,0q�5      $	��Top=�5      $	��683��6%      CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   
IsReadOnly	 . 
   Header$
 Fees Details Name��67      Width5  /System.Windows.Controls.DataGridLengthConverter$	 400 6t   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   ��  �� Path$ FeesName�6t   4  .System.Windows.Controls.DataGridTemplateColumn  5      	 . $
 Fees Amount��6;   $	 250 6P      CellTemplate 5      �� 5      .R�5      �� $��feesAmountTextBox��6&   -   5        ��5   l   �� $ 
FeesAmount� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   5      5      5"      �� 5#   
   -   5        $��totalTextBox��5#   9   $
��Left=�6   $��23��6-   $��446,404,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $	��Top=�6w   $	��277��6�   �� 5$   
   $��Total��6   $
��Left=�6    $��397,404,0,0q�6;   $	��Top=�6P   $��49��6h   $��23��6s   �� 5%   
   -   5        $
��Save��5%      $
��Left=�6    $��648,432,0,0q�6;   $	��Top=�6P   $��75��6h   6s   �� 5&   
   -	   5        $��CampusComboBox��5&   f   $
��Left=�6   $��
123,93,0,0q�6.   $	��Top=�6B   $	��277��6Z   #��[ 6}   �� 5'   
   $��Campus��6   $
��Left=�6!   $��	45,97,0,0q�6<   $	��Top=�6O   $��89��6g   5)      5*      