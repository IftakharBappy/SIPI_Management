   M S B A M L   `   `   `  ����  SIPI_SL#    SIPI_SL.UI.Fees.FeesDetailsUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
Setup Fees��5   	   $��373.846��6   $��423.495��6-    � ShowInTaskbar .   � 
ResizeMode$ CanMinimize=�6T    � WindowStartupLocation$ CenterScreen=�6m      	GrayWhite#��[  6�   .��5      � $��0,0,2,0q�6   .+�5   
   �� $
��Name��6   $
��Left=�6   $��	19,42,0,0q�6:   $	��Top=�6M   �� 5   
   -   5        $��feesNameTextBox��5   �   $
��Left=�6   $��23��6-   $��	86,42,0,0q�69    �� TextWrapping$
 Wrap=�6L   $	��Top=�6`   $	��120��6x   6�   �� 5	   
   -   5        $��feesDetailsListView��5      $	��175��5
      $��	34,86,0,0q�5      $	��Top=�5      $
��Left=�5   .   $	��358��6I      alternatingListViewItemStyle#��[ 5       �� AlternationCount$ 2��6P    � ContextMenu 5      �� 5      -   5        $��lstClassPeriod��5       �� 	StaysOpen . 
������� J� BitmapEffect 5      �� 5      .@�5      m� -   5        $��RemoveProgramContexMenu��5   .   $��Rmove��6   6M   5      	 �� View	 5      �� 5      
 �� AllowsColumnReorder
 . .P�5      �� $�� ��6N    �� Width$ 0��6X    �� DisplayMemberBinding 6%   ��  �� Path$ Id�6X   �� 5      $
��NAME��6T   $	 260��6b    6%   �� $ FeesName�6b   5      5      �� 5    
   -   5        $��
saveButton��5    }   $	��Add��6   $
��Left=�6   $��
225,42,0,0q�6:   $	��Top=�6N   $��75��6f   $��23��6q   6�   5"      5#      