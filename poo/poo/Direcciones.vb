Public Class Direcciones
    Public deptos() As String = {
        "Ahuachapán", "Santa Ana", "Sonsonate", "Usulután", "San Miguel", "Morazán", "La Unión", "San Salvador",
        "La Libertad", "Chalatenango", "Cuscatlán", "Cabañas", "San Vicente", "La Paz"
    }
    Public municipios()() As String = {
        New String() {"	Ahuachapán Norte", "Ahuachapán Centro", "Ahuachapán Sur"}, ' Ahuachapán
        New String() {"	Santa Ana Norte", "Santa Ana Centro", "Santa Ana Este", "Santa Ana Oeste"}, ' Santa Ana
        New String() {"	Sonsonate Norte", "Sonsonate Centro", "Sonsonate Este", "Sonsonate Oeste"}, ' Sonsonate
        New String() {"	Usulután Norte", "Usulután Este", "Usulután Oeste"}, ' Usulután
        New String() {"	San Miguel Norte", "San Miguel Centro", "San Miguel Oeste"}, ' San Miguel
        New String() {"	Morazán Norte", "Morazán Sur"}, ' Morazán
        New String() {"	La Unión Norte", "La Unión Sur"}, ' La Unión
        New String() {"	San Salvador Norte", "San Salvador Oeste", "San Salvador Este", "San Salvador Centro", "San Salvador Sur"}, ' San Salvador
        New String() {"	La Libertad Norte", "La Libertad Centro", "La Libertad Oeste", "La Libertad Este", "La Libertad Costa", "La Libertad Sur"}, ' La Libertad
        New String() {"	Chalatenango Norte", "Chalatenango Centro", "Chalatenango Sur"}, ' Chalatenango
        New String() {"	Cuscatlán Norte", "Cuscatlán Sur"}, ' Cuscatlán
        New String() {"	Cabañas Este", "Cabañas Oeste"}, ' Cabañas
        New String() {"	San Vicente Norte", "San Vicente Sur"}, ' San Vicente
        New String() {"	La Paz Oeste", "La Paz Centro", "La Paz Este"} ' La Paz
    }
    Public distritos()()() As String = {
        New String()() {
            New String() {"Atiquizaya", "El Refugio", "San Lorenzo", "Turín"}, ' Ahuachapán Norte
            New String() {"Ahuachapán", "Apaneca", "Concepcion de Ataco", "Tacuba"}, ' Ahuachapán Centro
            New String() {"Guaymango", "Jujutla", "San Francisco Menéndez", "San Pedro Puxtla"} ' Ahuachapán Sur
        },
        New String()() {
            New String() {"Masahuat", "Metapán", "Santa Rosa Guachipilín", "Texistepeque"}, ' Santa Ana Norte
            New String() {"Santa Ana"}, ' Santa Ana Centro
            New String() {"Coatepeque", "El Congo"}, ' Santa Ana Este
            New String() {"Candelaria de la Frontera", "Chalchuapa", "El Porvenir", "San Antonio Pajonal", "San Sebastián Salitrillo", "Santiago de la Frontera"} ' Santa Ana Oeste
        }
    }

End Class
