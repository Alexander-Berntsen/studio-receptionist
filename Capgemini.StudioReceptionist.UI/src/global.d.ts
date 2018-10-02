// Current environment
declare const ENV: string;

// Interface for the frontend configuration
interface IFrontendConfig {
    apiUrl: string;
}
// Configuration for the frontend which is delivered by using the files on configs/frontend
declare const CONFIG: IFrontendConfig;