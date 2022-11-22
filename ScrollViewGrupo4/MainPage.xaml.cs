namespace ScrollViewGrupo4;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        Label titleLabel = new Label
        {
            Text = "EL GATO NEGRO de Edgar Allan Poe",
            FontSize = 14,
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center
        };

        Label finalLabel = new Label
        {
            Text = "Mientras tanto, el gato se recuperó lentamente. La cuenca del ojo perdido presentaba, es cierto, un aspecto espantoso, pero ya no parecía sufrir ningún dolor. Recorrió la casa como de costumbre, pero, como era de esperar, huyó aterrorizado cuando me acerqué. Me quedaba tanto de mi antiguo corazón, que al principio me apenó esta evidente aversión por parte de una criatura que antes me había amado tanto. Pero este sentimiento pronto dio paso a la irritación. Y entonces llegó, como para mi derrocamiento final e irrevocable, el espíritu de PERVERSACIÓN. La filosofía no tiene en cuenta este espíritu. Sin embargo, no estoy más seguro de que mi alma vive, que de que la perversidad es uno de los impulsos primitivos del corazón humano, una de las facultades primarias indivisibles, o sentimientos, que dan dirección al carácter del hombre. ¿Quién no se ha encontrado, cien veces, cometiendo una acción vil o tonta, sin otra razón que la de saber que no debe hacerlo? ¿No tenemos una inclinación perpetua, en contra de nuestro mejor juicio, a violar lo que es Ley, simplemente porque entendemos que lo es? Este espíritu de perversidad, digo, llegó a mi derrocamiento final. Fue este insondable anhelo del alma de vejarse a sí misma, de ofrecer violencia a su propia naturaleza, de hacer el mal sólo por el mal, lo que me impulsó a continuar y, finalmente, a consumar la injuria que había infligido al bruto no ofensor. Una mañana, con la sangre fría, le puse un lazo en el cuello y lo colgué a la rama de un árbol; -- lo colgué con las lágrimas cayendo de mis ojos, y con el más amargo remordimiento en mi corazón; -- lo colgué porque sabía que me había amado, y porque sentía que no me había dado ninguna razón para ofenderme; -- la colgué porque sabía que al hacerlo estaba cometiendo un pecado -- un pecado mortal que pondría en peligro mi alma inmortal hasta colocarla -- si tal cosa fuera posible -- incluso fuera del alcance de la infinita misericordia del Dios Más Misericordioso y Más Terrible."
        };
        Image myImage = new Image { Source = "https://m.media-amazon.com/images/I/51SJHbIk2XL._SL500_.jpg",
            WidthRequest = 200 };

        StackLayout stackLayout = new StackLayout();
        stackLayout.Add(myImage);
        stackLayout.Add(new Label { Text = "Para la narración más descabellada, aunque más casera, que estoy a punto de escribir, no espero ni solicito creencia. Sería una locura esperarla, en un caso en el que mis propios sentidos rechazan su propia evidencia. Sin embargo, no estoy loco, y seguramente no sueño. Pero mañana moriré, y hoy quiero desahogar mi alma. Mi propósito inmediato es poner ante el mundo, de forma clara, sucinta y sin comentarios, una serie de meros acontecimientos domésticos. En sus consecuencias, estos eventos me han aterrorizado - han torturado - me han destruido. Sin embargo, no intentaré exponerlos. A mí me han parecido poco más que horror, y a muchos les parecerán menos terribles que los barrocos. En el futuro, tal vez, se encuentre algún intelecto que reduzca mi fantasma a lo común, algún intelecto más calmado, más lógico y mucho menos excitable que el mío, que perciba, en las circunstancias que detallo con asombro, nada más que una sucesión ordinaria de causas y efectos muy naturales." });
        stackLayout.Add(new Label { Text = "Desde mi infancia me distinguí por la docilidad y la humanidad de mi disposición. Mi ternura de corazón era incluso tan conspicua como para convertirme en la burla de mis compañeros. Me gustaban especialmente los animales, y mis padres me consentían con una gran variedad de mascotas. Con ellos pasaba la mayor parte de mi tiempo, y nunca fui tan feliz como cuando los alimentaba y acariciaba. Esta peculiaridad de carácter creció con mi crecimiento y, en mi madurez, derivé de ella una de mis principales fuentes de placer. Para aquellos que han apreciado el afecto por un perro fiel y sagaz, no es necesario que me tome la molestia de explicar la naturaleza o la intensidad de la gratificación así obtenida. Hay algo en el amor desinteresado y abnegado de un animal, que llega directamente al corazón de quien ha tenido frecuentes ocasiones de poner a prueba la mísera amistad y la fidelidad de un simple hombre." });
        stackLayout.Add(new Label { Text = "Me casé pronto y me alegré de encontrar en mi esposa una disposición que no era ajena a la mía. Observando mi afición por los animales domésticos, no perdió la oportunidad de conseguir los más agradables. Teníamos pájaros, peces de colores, un buen perro, conejos, un pequeño mono y un gato." });
        stackLayout.Add(new Label { Text = "Este último era un animal notablemente grande y hermoso, completamente negro y sagaz hasta un grado asombroso. Al hablar de su inteligencia, mi esposa, que en el fondo estaba un poco teñida de superstición, aludía con frecuencia a la antigua noción popular, que consideraba a todos los gatos negros como brujas disfrazadas. No es que ella hablara en serio sobre este punto, y menciono el asunto sin más razón que la de recordarlo ahora." });
        stackLayout.Add(new Label { Text = "Pluto -- así se llamaba el gato -- era mi mascota favorita y mi compañero de juegos. Sólo yo le daba de comer y me acompañaba a todos los sitios de la casa. Incluso era difícil evitar que me siguiera por las calles." });
        stackLayout.Add(new Label { Text = "Nuestra amistad duró, de este modo, varios años, durante los cuales mi temperamento y mi carácter en general -por medio del demonio de la intemperancia- habían experimentado (me ruboriza confesarlo) una alteración radical para peor. Me volví, día a día, más malhumorado, más irritable, más indiferente a los sentimientos de los demás. Me permitía usar un lenguaje destemplado con mi esposa. Al final, incluso le ofrecí violencia personal. Mis animales domésticos, por supuesto, sintieron el cambio en mi disposición. No sólo los descuidé, sino que los maltraté. Sin embargo, por Plutón aún conservaba el suficiente aprecio para no maltratarlo, como no tenía escrúpulos en maltratar a los conejos, al mono o incluso al perro, cuando por accidente o por afecto se cruzaban en mi camino. Pero mi enfermedad creció en mí -¡pues qué enfermedad es como el alcohol! -- y al final hasta Plutón, que ya se estaba haciendo viejo y, por consiguiente, algo malhumorado -- incluso Plutón empezó a experimentar los efectos de mi mal genio." });
        stackLayout.Add(new Label { Text = "Una noche, volviendo a casa, muy embriagado, de uno de mis rincones de la ciudad, me pareció que el gato evitaba mi presencia. Lo agarré; cuando, asustado por mi violencia, me infligió una ligera herida en la mano con sus dientes. La furia de un demonio me poseyó al instante. Ya no me conocía. Mi alma original pareció, de inmediato, huir de mi cuerpo; y una malevolencia más que diabólica, alimentada por la ginebra, estremeció cada fibra de mi cuerpo. Saqué del bolsillo de mi chaleco una navaja, la abrí, agarré a la pobre bestia por el cuello y le corté deliberadamente un ojo de la cuenca. Me sonrojo, ardo, me estremezco, mientras escribo la maldita atrocidad." });
        stackLayout.Add(new Label { Text = "Cuando por la mañana recuperé la razón -cuando ya había dormido los vapores de la borrachera nocturna- experimenté un sentimiento mitad de horror, mitad de remordimiento, por el crimen del que había sido culpable; pero fue, en el mejor de los casos, un sentimiento débil y equívoco, y el alma permaneció intacta. Volví a sumergirme en los excesos, y pronto ahogué en vino todo recuerdo del hecho." });
        stackLayout.Add(finalLabel);

        ScrollView scrollView = new ScrollView();
        scrollView.Content = stackLayout;
        scrollView.Scrolled += (s, e) => Console.WriteLine($"ScrollX: {e.ScrollX}, ScrollY: {e.ScrollY}");

        Button button = new Button
        {
            Text = "Ir al final de la lectura"
        };
        button.Clicked += async (s, e) => await scrollView.ScrollToAsync(finalLabel, ScrollToPosition.End, true);

        Title = "ScrollView Grupo 4";
        Grid grid = new Grid
        {
            Margin = new Thickness(20),
            RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(0, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(0, GridUnitType.Auto) }
                }
        };
        grid.Add(titleLabel);
        //grid.Add(myImage);
        grid.Add(scrollView, 0, 1);
        grid.Add(button, 0, 2);

        Content = grid;
    }
    async void OnButtonClicked(object sender, EventArgs e)
    {
        await scrollView.ScrollToAsync(finalLabel, ScrollToPosition.End, true);
    }

    void OnScrollViewScrolled(object sender, ScrolledEventArgs e)
    {
        Console.WriteLine($"ScrollX: {e.ScrollX}, ScrollY: {e.ScrollY}");
    }

}

