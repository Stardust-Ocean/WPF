    // <!--Height="330" Width="520" WindowStartupLocation="CenterScreen" 
    //    WindowStyle="None" ResizeMode="NoResize" BorderThickness="1,0,1,1"
    //    BorderBrush="#FF3C74D6" AllowsTransparency="True"
    //    Loaded="Win_Loaded"  Closed="Win_Closed">
    //<Window.Resources>
    //    <Style TargetType = "{x:Type Button}" x:Key="NormalButtonStyle">
    //        <Setter Property = "Foreground" Value="White"/>
    //        <Setter Property = "BorderThickness" Value="0"/>
    //        <Setter Property = "BorderBrush" Value="Transparent"/>
    //        <Setter Property = "Background" Value="#FF16EDF7"/>
    //        <Setter Property = "Template" >
    //            < Setter.Value >
    //                < ControlTemplate TargetType="{x:Type Button}">
    //                    <Border x:Name="border" Background="{TemplateBinding Background}">
    //                        <ContentPresenter HorizontalAlignment = "Center" VerticalAlignment="Center"/>
    //                    </Border>

    //                    <ControlTemplate.Triggers>
    //                        <Trigger Property = "IsMouseOver" Value="True">
    //                            <Setter Property = "Foreground" Value="White"/>
    //                            <Setter TargetName = "border" Property="Background" Value="#FF40F1F1"/>
    //                        </Trigger>

    //                        <Trigger Property = "IsPressed" Value="True">
    //                            <Setter Property = "Foreground" Value="White"/>
    //                            <Setter TargetName = "border" Property="Background" Value="#FF52EEEE"/>
    //                        </Trigger>
    //                    </ControlTemplate.Triggers>
    //                </ControlTemplate>

    //            </Setter.Value>
    //        </Setter>
    //    </Style>

    //    <Style TargetType = "{x:Type Button}" x:Key="NotNormalButtonStyle">
    //        <Setter Property = "Foreground" Value="White"/>
    //        <Setter Property = "BorderThickness" Value="0"/>
    //        <Setter Property = "BorderBrush" Value="Transparent"/>
    //        <Setter Property = "Opacity" Value="0.8"/>
    //        <Setter Property = "Background" Value="#FF40A6A6"/>
    //        <Setter Property = "Template" >
    //            < Setter.Value >
    //                < ControlTemplate TargetType="{x:Type Button}">
    //                    <Border x:Name="border" Background="{TemplateBinding Background}">
    //                        <ContentPresenter HorizontalAlignment = "Center" VerticalAlignment="Center"/>
    //                    </Border>

    //                    <ControlTemplate.Triggers>
    //                        <Trigger Property = "IsMouseOver" Value="True">
    //                            <Setter Property = "Foreground" Value="White"/>
    //                            <Setter TargetName = "border" Property="Background" Value="#FF4C6C99"/>
    //                        </Trigger>

    //                        <Trigger Property = "IsPressed" Value="True">
    //                            <Setter Property = "Foreground" Value="White"/>
    //                            <Setter TargetName = "border" Property="Background" Value="#FF2E5387"/>
    //                        </Trigger>
    //                    </ControlTemplate.Triggers>
    //                </ControlTemplate>

    //            </Setter.Value>
    //        </Setter>
    //    </Style>

    //    <Storyboard x:Key="StoryboardWinLoaded">
    //        <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty="(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)" Storyboard.TargetName= "grid" >
    //            < EasingDoubleKeyFrame KeyTime= "0" Value= "0" >
    //                < EasingDoubleKeyFrame.EasingFunction >
    //                    < BackEase EasingMode= "EaseInOut" />
    //                </ EasingDoubleKeyFrame.EasingFunction >
    //            </ EasingDoubleKeyFrame >
    //            < EasingDoubleKeyFrame KeyTime= "0:0:0.4" Value= "1" >
    //                < EasingDoubleKeyFrame.EasingFunction >
    //                    < BackEase EasingMode= "EaseInOut" />
    //                </ EasingDoubleKeyFrame.EasingFunction >
    //            </ EasingDoubleKeyFrame >
    //        </ DoubleAnimationUsingKeyFrames >
    //        < DoubleAnimationUsingKeyFrames Storyboard.TargetProperty= "(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)" Storyboard.TargetName= "grid" >
    //            < EasingDoubleKeyFrame KeyTime= "0" Value= "0" >
    //                < EasingDoubleKeyFrame.EasingFunction >
    //                    < BackEase EasingMode= "EaseInOut" />
    //                </ EasingDoubleKeyFrame.EasingFunction >
    //            </ EasingDoubleKeyFrame >
    //            < EasingDoubleKeyFrame KeyTime= "0:0:0.4" Value= "1" >
    //                < EasingDoubleKeyFrame.EasingFunction >
    //                    < BackEase EasingMode= "EaseInOut" />
    //                </ EasingDoubleKeyFrame.EasingFunction >
    //            </ EasingDoubleKeyFrame >
    //        </ DoubleAnimationUsingKeyFrames >
    //        < ThicknessAnimationUsingKeyFrames Storyboard.TargetProperty= "(Border.BorderThickness)" Storyboard.TargetName= "window" >
    //            < EasingThicknessKeyFrame KeyTime= "0" Value= "0" />
    //            < EasingThicknessKeyFrame KeyTime= "0:0:0.3" Value= "0" />
    //            < EasingThicknessKeyFrame KeyTime= "0:0:0.4" Value= "1,0,1,1" />
    //        </ ThicknessAnimationUsingKeyFrames >
    //    </ Storyboard >
    //</ Window.Resources >
    //< Window.Background >
    //    < ImageBrush ImageSource= "NewFolder1/bg.png" />
    //</ Window.Background >
    //< Window.Triggers >
    //    < EventTrigger RoutedEvent= "FrameworkElement.Loaded" >
    //        < BeginStoryboard Storyboard= "{StaticResource StoryboardWinLoaded}" />
    //    </ EventTrigger >
    //</ Window.Triggers >
    //< Grid x:Name= "grid" RenderTransformOrigin= "0.5,0.5" >
    //    < Grid.RenderTransform >
    //        < TransformGroup >
    //            < ScaleTransform />
    //            < SkewTransform />
    //            < RotateTransform />
    //            < TranslateTransform />
    //        </ TransformGroup >
    //    </ Grid.RenderTransform >
    //    < Grid.RowDefinitions >
    //        < RowDefinition Height= "30" />
    //        < RowDefinition />
    //    </ Grid.RowDefinitions >

    //    < Grid Grid.Row= "0" MouseLeftButtonDown= "OnMouseLeftButtonDownAtTitlee" >
    //        < Grid.ColumnDefinitions >
    //            < ColumnDefinition />
    //            < ColumnDefinition Width= "40" />
    //            < ColumnDefinition Width= "40" />
    //        </ Grid.ColumnDefinitions >

    //        < TextBlock Grid.Column= "0" VerticalAlignment= "Center"
    //                   Text= "{Binding MessageBoxTitle}" Margin= "20,0,0,0"
    //                   ToolTip= "{Binding RelativeSource={RelativeSource Self}, Path=Text}"
    //                   Foreground= "#FF0DDEF3" FontWeight= "Bold" FontSize= "15" />

    //        < Button Click= "MinWindowButton_Click" Style= "{StaticResource NormalButtonStyle}" Grid.Column= "1" BorderBrush= "{x:Null}" >
    //            < Line X1= "0" X2= "15" Fill= "White" Stroke= "White" StrokeThickness= "1" />
    //        </ Button >

    //        < Button Grid.Column= "2" Click= "CloseWindowButton_Click" Style= "{StaticResource NormalButtonStyle}" BorderBrush= "{x:Null}" >

    //            < Canvas >
    //                < Line X1= "-10" Y1= "-10" X2= "10" Y2= "10" Fill= "White" Stroke= "White" StrokeThickness= "1" />
    //                < Line X1= "-10"  Y1= "10"  X2= "10" Y2= "-10" Fill= "White" Stroke= "White" StrokeThickness= "1" />
    //            </ Canvas >
    //        </ Button >
    //    </ Grid >

    //    < Grid Grid.Row= "1" >
    //        < Grid >
    //            < Grid.RowDefinitions >
    //                < RowDefinition />
    //                < RowDefinition Height= "50" />
    //            </ Grid.RowDefinitions >

    //            < StackPanel Grid.Row= "0" VerticalAlignment= "Center" Orientation= "Horizontal" >
    //                < Image Source= "{Binding ImagePath}" />
    //                -->< !--< TextBlock VerticalAlignment= "Center" HorizontalAlignment= "Stretch" TextWrapping= "WrapWithOverflow" Margin= "30" Width= "300"
    //                       Text= "{Binding MessageBoxText}"
    //                       ToolTip= "{Binding RelativeSource={RelativeSource Self}, Path=Text}" Height= "82" /> -->< !--
    //                < TextBlock VerticalAlignment= "Center" HorizontalAlignment= "Left" TextWrapping= "Wrap" Margin= "50,0,0,0" Width= "400"
    //                       Text= "{Binding MessageBoxText}" Foreground= "#FF03E8FF" FontSize= "16" FontFamily= "Tekton Pro Cond"
    //                     />
    //            </ StackPanel >

    //            < StackPanel Grid.Row= "1" Orientation= "Horizontal" HorizontalAlignment= "Center" >
    //                < Button Content= "确认" x:Name= "OKButton" Width= "70" Height= "50" Click= "OKButton_Click" Margin= "20,0,20,0"
    //                        Style= "{StaticResource NormalButtonStyle}"
    //                        Visibility= "{Binding OKButtonVisibility, Mode=OneWay}" >


    //                </ Button >
    //                < Button Content= "是"  x:Name= "YesButton" Width= "70" Height= "50" Click= "YesButton_Click" Margin= "20,0,20,0"
    //                        Style= "{StaticResource NormalButtonStyle}"
    //                        Visibility= "{Binding YesButtonVisibility, Mode=OneWay}" >


    //                </ Button >
    //                < Button Content= "否" x:Name= "NoButton" Width= "70" Height= "50" Click= "NoButton_Click" Margin= "20,0,20,0"
    //                        Style= "{StaticResource NormalButtonStyle}"
    //                        Visibility= "{Binding NoButtonVisibility, Mode=OneWay}" >


    //                </ Button >
    //                < Button Content= "取消" x:Name= "CancelButton" Width= "70" Height= "50" Click= "CancelButton_Click" Margin= "20,0,20,0"
    //                        Style= "{StaticResource NormalButtonStyle}"
    //                        Visibility= "{Binding CancelButtonVisibility, Mode=OneWay}" >


    //                </ Button >
    //            </ StackPanel >
    //        </ Grid >
    //    </ Grid >
    //</ Grid > -->
