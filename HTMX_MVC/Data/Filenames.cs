namespace HTMX_MVC.Data
{
    public static class Filenames
    {
        // Mock data for a wiki search feature
        public static IReadOnlyCollection<FileInfo> GetFilenames()
        {
            return new FileInfo[] {
                new FileInfo() {Activity= "Getting Started", Area= "Introduction"},
                new FileInfo() {Activity= "Code Style Guide", Area= "Development Practices"},
                new FileInfo() {Activity= "Testing Strategy", Area= "Quality Assurance"},
                new FileInfo() {Activity= "Database Schema", Area= "Data Management"},
                new FileInfo() {Activity= "API Documentation", Area= "Interfaces"},
                new FileInfo() {Activity= "Deployment Process", Area= "Operations"},
                new FileInfo() {Activity= "Monitoring Tools", Area= "Operations"},
                new FileInfo() {Activity= "Troubleshooting Guide", Area= "Support"},
                new FileInfo() {Activity= "Product Roadmap", Area= "Planning"},
                new FileInfo() {Activity= "Release Notes", Area= "Updates"},
                new FileInfo() {Activity= "Team Contacts", Area= "Organization"},
                new FileInfo() {Activity= "Meeting Notes", Area= "Collaboration"},
                new FileInfo() {Activity= "Security Guidelines", Area= "Security"},
                new FileInfo() {Activity= "Performance Testing", Area= "Quality Assurance"},
                new FileInfo() {Activity= "User Manual", Area= "Documentation"},
                new FileInfo() {Activity= "Data Privacy", Area= "Legal"},
                new FileInfo() {Activity= "Accessibility Guidelines", Area= "User Experience"},
                new FileInfo() {Activity= "Localization", Area= "Internationalization"},
                new FileInfo() {Activity= "Code Review Process", Area= "Development Practices"},
                new FileInfo() {Activity= "Architecture Diagram", Area= "Design"},
                new FileInfo() {Activity= "Error Handling", Area= "Development Practices"},
                new FileInfo() {Activity= "Logging Strategy", Area= "Operations"},
                new FileInfo() {Activity= "Continuous Integration", Area= "DevOps"},
                new FileInfo() {Activity= "Continuous Deployment", Area= "DevOps"},
                new FileInfo() {Activity= "Version Control", Area= "Development Practices"},
                new FileInfo() {Activity= "Coding Standards", Area= "Development Practices"},
                new FileInfo() {Activity= "Refactoring Techniques", Area= "Development Practices"},
                new FileInfo() {Activity= "Design Patterns", Area= "Design"},
                new FileInfo() {Activity= "Code Optimization", Area= "Performance"},
                new FileInfo() {Activity= "Scalability Strategies", Area= "Architecture"},
                new FileInfo() {Activity= "Disaster Recovery Plan", Area= "Operations"},
                new FileInfo() {Activity= "Service Level Agreements", Area= "Support"},
                new FileInfo() {Activity= "Incident Response", Area= "Operations"},
                new FileInfo() {Activity= "Postmortem Analysis", Area= "Quality Assurance"}
            };
        }
    }
}
