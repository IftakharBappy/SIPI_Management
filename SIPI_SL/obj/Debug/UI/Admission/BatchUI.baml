   M S B A M L   `   `   `  ����  SIPI_SL"    SIPI_SL.UI.Admission.BatchUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  BatchUI��5   	   $��420.596��6   $��571.796��6*      	GrayWhite#��[  6:    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6y   .��5      � .+�5   
   �� $��Batch��6   $
��Left=�6"   $��
127,15,0,0q�6=   $	��Top=�6Q   $	��198��6i   $	��294��6v   $
��Bold"�6�   .��5      � .+�5      �� $
��Year��6   $
��Left=�6'   $��26��6B   $	��Top=�6N   $��75��6f   $��	10,50,0,0q�6q    J� RenderTransformOrigin$ 3.342,-0.195&�6�   �� 5	      $��Batch��6   $
��Left=�6(   $��35��6C   $	��Top=�6O   $��80��6g   $��	10,10,0,0q�6r   �� 5
      -   5        $��batchTextBox��5
      $��114,10,10,0q�6.   $��28��6C   $	��Top=�6O   �� 5      -   5        $��yearTextBox��5      $��114,50,10,0q�6-   $��28��6B   $	��Top=�6N   �� 5      -   5        $��submitButton��5   U   $��131,0,10,10q�6   $
��Save��6/   $��28��6i   $��Bottom=�6u   $ 
0.909,2.21&�6�   �� 5      $��Batch in Bangla��6   $
��Left=�62   $��26��6M   $	��Top=�6Y   $��99��6q   $��	10,83,0,0q�6|   $ 3.342,-0.195&�6�   �� 5      -   5         ��Name$ banglaBatchTextBox��5      $��114,83,10,0q�66   $��28��6K   $	��Top=�6W   5      5      �� 5   
   $��Batch��6   $
��Left=�6"   $��
27,213,0,0q�6=   $	��Top=�6Q   $	��167��6i   $	��486��6v   .��5      � $
��Left=�6   $	��137��6.   $	��Top=�6;   $	��476��6S   $��0,0,-2,0q�6_    � ColumnDefinitions 5      �� 5      $��2* �6'   �� 5      $
��211* �6'   .+�5      �� -   5        $��batchlistView��5      $	��117��5      $��	10,10,0,0q�5      $	��Top=�5      $��1��61   $
��Left=�6A   $	��452��6\      alternatingListViewItemStyle#��[ 5       �� AlternationCount$ 2��6\    � ContextMenu 5      �� 5      -   5        $��ZoneIformationList��5   &    �� 	StaysOpen . 
�������	 J� BitmapEffect	 5      �� 5    "   .@�5"      m� -   5        $��EditDepartmentContextMenu��5"   5   $
��Edit��6'   6V   m� 5#      -   5        $!��RemoveDepartmentContextMenu��5#   7   $��Remove��6'   6Z   5$      
 �� View
 5&      �� 5'       �� AllowsColumnReorder . .P�5(      �� $�� ��6V    �� Width$ 0��6`    �� DisplayMemberBinding 6-   ��  �� Path$ Id�6`   �� 5)      $��Batch��6[   $	 100��6j    6-   �� $ BatchNo�6j   �� 5*      $
��Year��6X   $	 100��6f    6-   �� $
 Year�6f   �� 5+      $��Bangla Batch��6`   $	 100��6v    6-   �� $ BanglaBatch�6v   5-      5/      50      51      54      57      