   M S B A M L   `   `   `  ����  SIPI_SL)    #SIPI_SL.UI.Admission.SIPI_ProgramUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
Program UI��5   	   $��414.208��6   $��583.962��6-      	GrayWhite#��[  6=    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6|   .��5      �  � ColumnDefinitions 5   
   �� 5      .+�5	   
   �� $��Program Nme��6   $
��Left=�6&   $��	47,73,0,0q�6A   $	��Top=�6T   $��26��6l   $	��102��6x   �� 5
   
   -   5        $��SipiProgramNameTextBox��5
   �   $
��Left=�6   $��23��6-   $��
186,76,0,0q�69    �� TextWrapping$
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��120��6�   6�   �� 5   
   $��Duration Time��6   $
��Left=�6(   $��
47,102,0,0q�6C   $	��Top=�6W   $��26��6o   $	��105��6{   �� 5   
   $
��Year��6   $
��Left=�6   $��318,103,0,0q�6:   $	��Top=�6O   $��26��6g   $��45��6s   �� 5   
   -   5        $��SipiProgramTimeTextBox��5   �   $
��Left=�6   $��23��6-   $��186,104,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   6�   �� 5   
   $��GroupBox��6   $
��Left=�6%   $��
40,176,0,0q�6@   $	��Top=�6T   $	��197��6l   $	��464��6y   .��5      � $
��Left=�6   $	��162��6.   $	��Top=�6;   $	��426��6S   $��0,0,-2,0q�6_    5      �� 5      $��2* �6'   �� 5      $
��211* �6'   .+�5      �� -   5        $��sIPI_programlistView��5      $	��156��5      $
��Left=�5      $��	2,6,-12,0q�5      $	��Top=�5      $	��432��5      $��1��6%      alternatingListViewItemStyle#��[ 5       �� AlternationCount$ 2��6\    � ContextMenu 5      �� 5      -   5        $��ZoneIformationList��5   &    �� 	StaysOpen . 
������� J� BitmapEffect 5      �� 5    "   .@�5"      m� -   5        $��EditDepartmentContextMenu��5"   5   $
��Edit��6'   6W   m� 5#      -   5        $!��RemoveDepartmentContextMenu��5#   7   $��Remove��6'   6Z   5$      	 �� View	 5&      �� 5'      
 �� AllowsColumnReorder
 . .P�5(      �� $�� ��6V    �� Width$ 0��6`    �� DisplayMemberBinding 6-   ��  �� Path$ Id�6`   �� 5)      $��Program Name��6d   $	 200��6z    6-   �� $ SIPI_ProgramName�6z   �� 5*      $��Duration Time��6d   $	 100��6{    6-   �� $ SIPI_ProgramTime�6{   �� 5+      $��Bangla Program Name��6j   $	 100��6�    6-   �� $ BanglaSIPI_ProgramName�6�   5-      5/      50      51      �� 52   
   -   5        $��submitButton��52   s   $
��Save��6   $
��Left=�6    $��395,150,0,0q�6;   $	��Top=�6P   $��75��6h   $��22��6�   �� 53   
   $��Program In Bangla��6   $
��Left=�6,   $��
47,128,0,0q�6G   $	��Top=�6[   $��26��6s   $	��140��6   �� 54   
   -   5         ��Name$ banglaSipiProgramTextBox��54   �   $
��Left=�6   $��23��6-   $��186,130,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   6�   �� 55   
   -	   5         ��Name$ clearButton��55   t   $��Clear��6   $
��Left=�6!   $��311,149,0,0q�6<   $	��Top=�6Q   $��75��6i   $��22��6�   6�   57      58      