   M S B A M L   `   `   `  ����  SIPI_SL'    !SIPI_SL.UI.Admission.DepartmentUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Department UI��5   	   $	��426��6   $	��525��6,      	GrayWhite#��[  68    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6v   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5
   
   �� $��Department Nme��6   $
��Left=�6)   $��	47,73,0,0q�6D   $	��Top=�6W   $��26��6o   $	��102��6{   �� 5   
   -   5        $��departmentNameTextBox��5   �   $
��Left=�6   $��23��6-   $��
186,76,0,0q�69    �� TextWrapping$
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��120��6�   6�   �� 5   
   $��Department Code��6   $
��Left=�6*   $��
47,111,0,0q�6E   $	��Top=�6Y   $��26��6q   $	��105��6}   �� 5   
   -   5        $��departmentCodeTextBox��5   �   $
��Left=�6   $��23��6-   $��186,113,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   6�   �� 5   
   $��GroupBox��6   $
��Left=�6%   $��
40,176,0,0q�6@   $	��Top=�6T   $	��184��6l   $	��436��6y   .��5      � $
��Left=�6   $	��162��6.   $	��Top=�6;   $	��426��6S   $��0,0,-2,0q�6_    5      �� 5      $��2* �6'   �� 5      $
��211* �6'   .+�5      �� -   5        $��departmentlistView��5      $	��156��5      $
��Left=�5      $��12,6,0,0q�5      $	��Top=�5      $	��400��5      $��1��6%      alternatingListViewItemStyle#��[ 65    �� AlternationCount$ 2��6x    � ContextMenu 5   "   �� 5   *   -   5        $��ZoneIformationList��5   6    �� 	StaysOpen . 
������� J� BitmapEffect 5   *   �� 5   *   .@�5    2   m� -   5        $��EditDepartmentContextMenu��5    I   $
��Edit��6;   6k   m� 5!   2   -   5        $!��RemoveDepartmentContextMenu��5!   K   $��Remove��6;   6n   5"   ,   	 �� View	 5$   "   �� 5%   *   
 �� AllowsColumnReorder
 . .P�5&      �� $�� ��6V    �� Width$ 0��6`    �� DisplayMemberBinding 6-   ��  �� Path$ Id�6`   �� 5'      $��Department Name��6b   $	 200��6{    6-   �� $ DepartmentName�6{   �� 5(      $
��Code��6b   $	 100��6p    6-   �� $ DepartmentCode�6p   �� 5)      $��Bangla Department Name��6d   $	 100��6�    6-   �� $ BanglaDepartment�6�   5+      5-      5.      5/      �� 50   
   -   5        $��submitButton��50   s   $
��Save��6   $
��Left=�6    $��348,150,0,0q�6;   $	��Top=�6P   $��75��6h   $��22��6�   �� 51   
   $��Department In Bangla��6   $
��Left=�6/   $��
47,146,0,0q�6J   $	��Top=�6^   $��26��6v   $	��140��6�   �� 52   
   -   5         ��Name$ banglaDepartmentTextBox��52   �   $
��Left=�6   $��23��6-   $��186,148,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   6�   54      55      