   M S B A M L   `   `   `  ����   SIPI_SL"    SIPI_SL.UI.Login.UserSetUpUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
User SetUp��$	��451��$	��638�� � ShowInTaskbar .   � 
ResizeMode$ CanMinimize=� � WindowStartupLocation$ CenterScreen=�   	GrayWhite#��[  .��� .+��� -   $��	groupBox1��$��New User Information��$	��146��$��
37,44,38,0q�$	��Top=�.��� .+��� -   $��txtUserName��$��23��$
��Left=�$��	79,14,0,0q�  GraywithBlueBorderTextBox#��[ $	��Top=�$	��178��G� -   $��txtPassword��
��� � �$��23��$
��Left=�$��	79,47,0,0q�$	��Top=�$	��178��G� -   $��txtConfirmPass��
��� � �$��23��$
��Left=�$��	79,80,0,0q�$	��Top=�$	��178���� -   $��cmbUserGroup��$��23��$
��Left=�$��
328,14,0,0q�  ComboBoxBGYellowGreen#��[ $	��Top=�$	��178���� -   $��
btnAddUser�����	#00000000$	��Add��$��23��$
��Left=�$��
350,80,0,0q�$	��Top=�$��75���� -   $��btnResetUser�����	#00000000$��Reset��$��23��$
��Left=�$��
434,80,0,0q�$	��Top=�$��75���� -   $��label1��$��	User name��$��28��$
��Left=�$��	15,12,0,0q�$	��Top=��� -	   $��label2��$��Re type��$��28��$
��Left=�$��	32,75,0,0q�$	��Top=��� -
   $��label3��$��Password��$��28��$
��Left=�$��	19,42,0,0q�$	��Top=��� -   $��label4��$��Group��$��28��$
��Left=�$��
277,12,0,0q�$	��Top=��� -   $��	groupBox2��$��List Of User��$	��162��$��37,196,38,0q�$	��Top=�.��� .+��� -   $��lvUser��$	��130��$
��Left=�$��5,4,0,0q�$	��Top=�$	��520��   alternatingListViewItemStyle#��[  �� AlternationCount$ 2�� � ContextMenu �� 
������� �� 	StaysOpen .  J� BitmapEffect �� .@�m� -   $��EditUser��$
��Edit��m� -   $��
RemoveUser��$��Remove�� �� View �� .P��� $��	User Name��	 �� Width$		 190��
 �� DisplayMemberBinding
 ��  �� Path$ UserName��� $��Password��$		 120��
 �� $ UserPassword��� $��User Group Name��$		 190��
 �� $ UserGroupName��� -   $��label5��$��
User Setup��$��LeftToRight=�$��18(�$
��Bold"�$��33��$��240,0,251,0q�$	��Top=��� -   $��button1�����	#00000000$��Close��$��23��$
��Left=�$��503,372,0,0q�$	��Top=�$��75��