   M S B A M L   `   `   `  ����   SIPI_SL'    !SIPI_SL.UI.Login.MenuPermissionUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Menu Permission��$	��503��$	��607�� � ShowInTaskbar .   � 
ResizeMode$ CanMinimize=� � WindowStartupLocation$ CenterScreen=�   	GrayWhite#��[   � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType	 J� SnapsToDevicePixels  TreeViewItemFocusVisual  ExpandCollapseToggleStyle
 � 	Resources  Key g� RepeatBehavior g� 	BeginTime �� 
TargetName �� TargetProperty O� KeyTime O� Value ��Name J� BitmapEffect O� 	GlowColor O� GlowSize F�Name �� Triggers P� Property P� Value �� 
TargetName N� ExitActions ��Name  Storyboard2 N� EnterActions  Storyboard1 �� Path �� RelativeSource �� AncestorType  �� KeyTime! �� Value" � ColumnDefinitions# � RowDefinitions$ d�Name% �� 	ClickMode& d� 	IsChecked' ��Name( O� Opacity) �� Padding* ��Name+ ��Name, ]� 
Conditions- �� Property. �� Value��%1  'R�       &	 L    &	 r    7  7  'Q� �    7  7  7  7  �� " R�.���  � �� �	#3f000000��  � �� �#1ef009��  � ��$ 1q���  � ��$ 1q���  � ��# � ����  � ��$
 Auto=���  � ��$
 Auto=���  � ��$ Center=���  � �� �� " R�.R��� 	 . #��z��#��z��#��z��._��� |�.  
������ #��z����.  #��z��#��z��.���� �� .���  � �� �� .R��� �� " d�.���  � |� .  ��  � ��$ 19����  � ��$ 13����  � �� �#000000��  � �� �� " d�
 ���� Storyboard1 $ Forever��.��U� $ 00:00:00X�$ border��$? 9(UIElement.BitmapEffect).(OuterGlowBitmapEffect.GlowSize)�.\��� $ 00:00:00��$ 1Q��� $ 
00:00:00.3��$ 6Q��� $ 
00:00:00.5��$ 2Q��� Storyboard2 .��U� $ 00:00:00X�$ border��$? 9(UIElement.BitmapEffect).(OuterGlowBitmapEffect.GlowSize)�.\��� $ 00:00:00��$ 6Q��� $ 00:00:00.3000000��$ 1Q�.R��� $��19��$��13��
������ ._��� $ border��	 . $��9��$��9��#��z�� O� $ #FFFFFF��$ 1Q�._�F� $ 
ExpandPath��$��Center=�$��Center=�$��1,1,1,1q�#��z��s����    �� �    ��- р� ��- р� @KL ���- @KL ���- ��- �@KL ��- �@KL �� ���- �� ���-     р�     р� �� 	 P�  �@d�	IsChecked$
 TrueY�. ��� $ 
ExpandPath�� � ��+ ��    �� �    ��- �@KL ��- �@KL �� 	P�  �@J�IsMouseOver .  �� $! Storyboard2_BeginStoryboard��8��   �� 8�� �� " Q�.���  � ��
 ���� ��  � �� �� $  HorizontalContentAlignment� �� " ����  � �� �� $ VerticalContentAlignment� �� " ����  � ��$ 1,0,0,0q���  � �� �#FFFFFF��  � ��$ 13(���  � ��$ Tahoma)���  � ��$
 Bold"���  �@�FocusVisualStyle8   ��  � �� �� " Q�
 ���� Storyboard1 .���� $ 00:00:00X�$ Bd��$0 *(Panel.Background).(SolidColorBrush.Color)�.g��� $  00:00:00��$! 	#00000000���� $  00:00:00.3000000��$! 	#4C000000��U� $ 00:00:00X�$ 	whiteRect��$? 9(UIElement.BitmapEffect).(OuterGlowBitmapEffect.GlowSize)�.\��� $ 00:00:00��$ 4Q��� $ 00:00:00.3000000��$ 6Q�U� $ 00:00:00X�$ 	whiteRect��$> 8(UIElement.BitmapEffect).(OuterGlowBitmapEffect.Opacity)�.\��� $ 00:00:00��$
 0.75Q��� $ 00:00:00.3000000��$ 1Q��� Storyboard2 .���� $ 00:00:00X�$ Bd��$0 *(Panel.Background).(SolidColorBrush.Color)�.g��� $  00:00:00��$! 	#4C000000���� $  
00:00:00.3��$! 	#00000000��U� $ 00:00:00X�$ 	whiteRect��$? 9(UIElement.BitmapEffect).(OuterGlowBitmapEffect.GlowSize)�.\��� $ 00:00:00��$ 6Q��� $ 00:00:00.3000000��$ 4Q�U� $ 00:00:00X�$ 	whiteRect��$> 8(UIElement.BitmapEffect).(OuterGlowBitmapEffect.Opacity)�.\��� $ 00:00:00��$ 1Q��� $ 00:00:00.3000000��$
 0.75Q�.R�� " �� $��19��$
��Auto ��� $
��Auto ��� $��* �# �� $
��Auto ��� .+��� $ Bd��$��3�����	#00000000d� $$ Expander��#��z��8�� $% Press=�& �� $ 
IsExpanded� �� *TemplatedParent+�� $' 	whiteRect��$��3��$��7��$	��3,0q�$��Center=����#FFFFFF$��Center=�$y�	Collapsed=� O� $ #FFFFFF��$ 4Q�$
( 0.75Q��� 	 . $��1��#��z��#��z��#) z��._��� $* PART_Header��#	 z	 #��z��$��Header���� $+ 	ItemsHost��$��1��$��2��$��1�� P�  �@Q�
IsExpanded .  . ��� $ 	ItemsHost�� � y�$ 	Collapsed=�P�  �@J�IsMouseOver . . ���  � �� �#1ef009P�  �@��HasItems .  . ��� $ Expander�� � y�$ Hidden=���  � ��$ 11(���  � ��$ Normal"���  � �� �#1ef009�� $ 	whiteRect�� � y�$ Visible=�P�  �@Q�
IsSelected . . ��� $ Bd�� � �� �	#7F000000]� , �� - �@J�IsMouseOver. . �� - �@��HasItems. .   �� $! Storyboard2_BeginStoryboard��8��  �� 8�� ]� , �� - �@Q�
IsSelected. . �� - �@Q�IsSelectionActive. .  ./��� $ Bd��# � �� � ���� # � �� � ��P�  � {� .  . ��� # � �� � ��.��� .+��� -   $��	groupBox3��$��Select Group And Module��$��61��$
��Left=�$��	39,40,0,0q�$	��Top=�$	��508��.��� .+��� -   $��label12��$��Module��$��28��$
��Left=�$��	259,3,0,0q�$	��Top=��� -   $��cmbModuleName��$��23��$
��Left=�$��	316,6,0,0q�/ �� DisplayMemberPath$/ 
ModuleName��$	��Top=�$	��157��  ComboBoxBGYellowGreen#��[ �� -   $��	groupBox2��$��Permitted Menu��$	��285��$
��Left=�$��316,127,0,0q�$	��Top=�$	��228��.��� �� -   $��	groupBox1��$��Not Permitted Menu��$	��284��$
��Left=�$��
39,126,0,0q�$	��Top=�$	��224��.��� R� -   $��treePermittedMenu��$	��255��$
��Left=�$��326,148,0,0q�$	��Top=�$	��206���� -   $��btnMoveMenuItem�����	#00000000$��>��$��23��$
��Left=�$��272,170,0,0q�$	��Top=�$��31���� -   $��btnMoveAllMenuItem�����	#00000000$��>>��$��23��$
��Left=�$��272,217,0,0q�$	��Top=�$��31���� -	   $��btnDeleteMenuItem�����	#00000000$��<��$��23��$
��Left=�$��272,311,0,0q�$	��Top=�$��31���� -
   $��btnDeleteAllMenuItem�����	#00000000$��<<��$��23��$
��Left=�$��272,350,0,0q�$	��Top=�$��31���� -   $��label10��$��
User Group��$��28��$
��Left=�$��	57,59,0,0q�$	��Top=��� -   $��cmbUserGroupMenuPerm��$��23��$
��Left=�$��
136,62,0,0q�$	��Top=�$	��156��#��[ �� -   $��btnSaveMenuPermission�����	#00000000$
��Save��$��23��$
��Left=�$��308,428,0,0q�$	��Top=�$��75���� -   $��btnDeleteMenuPermission�����	#00000000$��Delete��$��23��$
��Left=�$��389,428,0,0q�$	��Top=�$��75���� -   $��btnResetMenuPermission�����	#00000000$��Reset��$��23��$
��Left=�$��470,428,0,0q�$	��Top=�$��75��R� -   $��treeNotPermittedMenu��$	��255��$
��Left=�$��
48,146,0,0q�$	��Top=�$	��206���� -   $��label2��$��Menu Permission��$��LeftToRight=�$��18(�$
��Bold"�$��33��$��223,0,199,0q�$	��Top=�