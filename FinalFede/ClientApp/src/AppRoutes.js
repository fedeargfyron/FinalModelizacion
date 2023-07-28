import { MM1 } from "./Screens/MM1/MM1";
import { MM1N } from "./Screens/MM1N/MM1N";
import { MM2 } from "./Screens/MM2/MM2";
import { MG1 } from "./Screens/MG1/MG1";
import { Home } from "./Screens/Home";

const AppRoutes = [
    {
        index: true,
        element: <Home />
    },
    {
        path: '/MM1',
        element: <MM1 />
    },
    {
        path: '/MM1N',
        element: <MM1N />
    },
    {
        path: '/MM2',
        element: <MM2 />
    },
    {
        path: '/MG1',
        element: <MG1 />
    }
];

export default AppRoutes;
