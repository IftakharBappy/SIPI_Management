   M S B A M L   `   `   `  ����  SIPI_SL0    *SIPI_SL.UI.StudentManagement.ClassPeriodUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Class Period��5   	   $��365.945��6   $��601.393��6/      	GrayWhite#��[  6?    � ShowInTaskbar .  .��5      � $��0,0,0,-8q�6   .+�5   
   �� $��Insert Period Name:��6   $
��Left=�6.   $��	83,73,0,0q�6I   $	��Top=�6\   �� 5   
   -   5         ��Name$ txtPeriodName��5      $
��Left=�6)   $��23��6D   $��
203,76,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��172��6�   6�   �� 5   
   $��Start Time:��6   $
��Left=�6&   $��
83,104,0,0q�6A   $	��Top=�6U   �� 5	   
   -   5        $ txtStartTime��5	      $
��Left=�6(   $��23��6C   $��203,107,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��172��6�   �� 5
   
   $��	End Time:��6   $
��Left=�6$   $��
83,135,0,0q�6?   $	��Top=�6S   �� 5   
   -   5        $ 
txtEndTime��5      $
��Left=�6&   $��23��6A   $��203,138,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��172��6�   �� 5   
   $��Class Period Setup��6   $
��Left=�6-   $��
166,10,0,0q�6H   $	��Top=�6\   ���	#FF02A3D3$��Lucida Calligraphy)�6�   $��22(�6�   $��Italic$�6�   �� 5   
   -   5         ��Name$ btnNew��5      $	��New��6!   $
��Left=�6/   $��26��6J   $��
401,73,0,0q�6V   $	��Top=�6j   $	��100��6�   6�   �� 5   
   -   5        $��btnSave��5      $
��Save��6    $
��Left=�6/   $��26��6J   $��401,104,0,0q�6V   $	��Top=�6k   $	��100��6�   6�   �� 5   
   -   5        $ btnClase��5      $��Close��6#   $
��Left=�63   $��26��6N   $��401,135,0,0q�6Z   $	��Top=�6o   $	��100��6�   6�   �� 5   
   -   5        $��ClassPeriodListView��5      $
��Left=�5      $	��144��5      $��
83,178,0,0q�5      $	��Top=�5      $	��429��5       � ContextMenu 5      �� 5      -   5        $��lstClassPeriod��5       �� 	StaysOpen . 
������� J� BitmapEffect 5      �� 5      .@�5      m� -	   5        $��EditProgramContexMenu��5   -   $
��Edit��6   6J   m� 5      -
   5        $��RemoveProgramContexMenu��5   .   $��Rmove��6   6M   5       �� View 5       �� 5!      	 �� AllowsColumnReorder	 . .P�5"      �� $�� ��6N   
 �� Width$
 0��6X    �� DisplayMemberBinding 6%   ��  �� Path$ Id�6X   �� 5#      $��Period��6V   $	
 130��6f    6%   �� $ 
PeriodName�6f   �� 5$      $��
Start Time��6U   $	
 130��6i    6%   �� $ 	StartTime�6i   �� 5%      $��End Time��6S   $	
 130��6e    6%   �� $ EndTime�6e   5&      5(      5*      5+      