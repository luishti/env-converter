   M S B A M L   `   `   `  ����  Converter.UI    Converter.UI.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$"  Converter ENV LaunchSettings��5   	   $	��450��6.   $	��600��6;   .��5      �  � ColumnDefinitions 5	   
   �� 5
      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��1��6   $��env content��6   �� 5   
   -   5         ��Name$ textEnvContent��5      $��2��5      $��5q�6    �� TextWrapping$
 Wrap=�5       �� AcceptsReturn$
 True��5      " �� VerticalScrollBarVisibility$ Visible=�5      5      � 5   
   $��2��6   $��Right=�6   $��Bottom=�68   $��5,5,25,5q�6S   .+�5      �� -   5        $
��Save��5      6$   5      � 5   
   $��3��6    5      �� 5       $��* �6#   �� 5!      $
��Auto �6#   �� 5"      $��* �6#   .+�5$      �� -   5        $��Convert!��5$      $��1��6(   68   5%      �� 5&   
   $��4��6   $!��launchSettings.json content��6   �� 5'   
   -   5        $ textLaunchSettingsContent��5+      $��5��5'      $��5q�6   $
 Wrap=�5(      $
 True��5)      $ Visible=�5*      5+      � 5,   
   $��5��6   $��Right=�6   $��Bottom=�68   $��5,5,25,5q�6S   .+�5-      �� -   5        $
��Save��5-      6$   5.      �� 5/   
   $��6��6   $��1q�6   
�������._�50      � $��6��6    51      �� 52      $
��Auto �6'   �� 53      $��* �6'   .+�55      �� $��Convertion status:��6   �� 56      -   5         ��Name$ labelConvertionStatus��56   (   $��1��6   6(   57      58      59      5:      