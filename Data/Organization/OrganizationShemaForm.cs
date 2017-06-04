using AlimexDAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Linq;
using AlimexDAL.Entity;
using Telerik.Windows.Diagrams.Core;

namespace Organization
{
    public partial class OrganizationShemaForm : RadForm, IOrganiztionForm
    {
        internal static Telerik.Windows.Diagrams.Core.TreeLayoutSettings currentLayoutSettings;
        private Color[] groupColor = new Color[] { Color.FromArgb(49, 49, 49), Color.FromArgb(47, 153, 69), Color.FromArgb(36, 159, 217) };

        AppDbContext _userContext;
        List<AlimexDAL.Entity.Organization> _org;
        public OrganizationShemaForm()
        {
            _userContext = new AppDbContext(null);
            dbCheck();
            InitializeComponent();
            this.ThemeName = "TelerikMetro";
            this.ApplyThemeRecursively(this.Controls);
            this.prepearDiagram();
            this.prepertToTreeSettings();
            showShemaManuel();
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
        }

        private void dbCheck()
        {
            var a = _userContext.Users.ToList();
            if (a.Count == 0)
            {
                var role = new Role() { Name = "Director" };
                var role2 = new Role() { Name = "Supervizor" };
                var role3 = new Role() { Name = "User" };
                var role4 = new Role() { Name = "Asistan" };
                var role5 = new Role() { Name = "CEO" };
                _userContext.Roles.Add(role);
                _userContext.Roles.Add(role2);
                _userContext.Roles.Add(role3);
                _userContext.Roles.Add(role4);
                _userContext.Roles.Add(role5);
                _userContext.SaveChanges();

                var man = new AlimexDAL.Entity.Organization() { Name = "Management", Parent = 0 };
                var ik = new AlimexDAL.Entity.Organization() { Name = "IK", Parent = 1 };
                var Accounting = new AlimexDAL.Entity.Organization() { Name = "Accounting", Parent = 1 };
                var Production = new AlimexDAL.Entity.Organization() { Name = "Production", Parent = 1 };
                _userContext.Organization.Add(man);
                _userContext.Organization.Add(ik);
                _userContext.Organization.Add(Accounting);
                _userContext.Organization.Add(Production);
                _userContext.SaveChanges();

                User user;
                for (int i = 0; i < 5; i++)
                {
                    user = new User();
                    user.Name = "Ad" + i;
                    user.SurName = "soyad" + i;
                    user.Password = "1q2w3e";
                    user.Roles = new List<Role>();
                    user.Roles.Add(role3);
                    _userContext.Users.Add(user);
                }
                user = new User();
                user.Name = "Erkan";
                user.SurName = "Alkoç";
                user.Password = "1q2w3e";
                user.Roles = new List<Role>();
                user.Roles.Add(role);
                user.Organizations = new List<AlimexDAL.Entity.Organization>();
                user.Organizations.Add(Accounting);
                _userContext.Users.Add(user);


                user = new User();
                user.Name = "Ahmet";
                user.SurName = "Can";
                user.Password = "1q2w3e";
                user.Roles = new List<Role>();
                user.Roles.Add(role2);
                user.Organizations = new List<AlimexDAL.Entity.Organization>();
                user.Organizations.Add(Production);
                _userContext.Users.Add(user);

                user = new User();
                user.Name = "Admin";
                user.SurName = "Soyad";
                user.Password = "1q2w3e";
                user.Roles = new List<Role>();
                user.Roles.Add(role5);
                user.Organizations = new List<AlimexDAL.Entity.Organization>();
                user.Organizations.Add(man);
                _userContext.Users.Add(user);
                _userContext.SaveChanges();
            }

        }

        private void showShemaManuel()
        {
            this.PopulateWithData();
            this.radDiagram1.Zoom = 0.8;
            this.radDiagram1.DiagramElement.HorizontalScrollbar.Value = 250;
            this.radDiagram1.DiagramElement.VerticalScrollbar.Value = 100;
            this.radDiagram1.SetLayout(Telerik.Windows.Diagrams.Core.LayoutType.Tree, currentLayoutSettings);

        }
        private void prepearDiagram()
        {
            this.radDiagram1.BackColor = System.Drawing.Color.White;
            this.radDiagram1.IsInformationAdornerVisible = false;
            this.radDiagram1.ActiveTool = Telerik.Windows.Diagrams.Core.MouseTool.PanTool;
            this.radDiagram1.IsSnapToGridEnabled = false;
            this.radDiagram1.IsSnapToItemsEnabled = false;
            this.radDiagram1.RouteConnections = false;
            this.radDiagram1.RoutingService.Router = new Telerik.Windows.Diagrams.Core.OrgTreeRouter() { TreeLayoutType = Telerik.Windows.Diagrams.Core.TreeLayoutType.TreeDown };
            this.radDiagram1.RoutingService.AutoUpdate = true;
            this.radDiagram1.RouteConnections = true;
            this.radDiagram1.BackgroundGrid.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.radDiagram1.BackgroundPageGrid.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.radDiagram1.IsSettingsPaneEnabled = false;
        }

        private void prepertToTreeSettings()
        {
            currentLayoutSettings = new Telerik.Windows.Diagrams.Core.TreeLayoutSettings()
            {
                HorizontalSeparation = 120d,
                VerticalSeparation = 180d,
                UnderneathVerticalTopOffset = 50d,
                UnderneathHorizontalOffset = 230d,
                UnderneathVerticalSeparation = 40d,
                VerticalDistance = 10d,
            };
        }

        private void ApplyThemeRecursively(Control.ControlCollection controlCollection)
        {
            foreach (Control control in controlCollection)
            {
                RadControl radControl = control as RadControl;
                if (radControl != null)
                {
                    radControl.ThemeName = this.ThemeName;
                }

                this.ApplyThemeRecursively(control.Controls);
            }
        }

        private void PopulateWithData()
        {
            _org = _userContext.Organization.ToList();
            foreach (var item in _org.Where(x => x.Parent == 0))
            {
                OrgContainerShape node = this.CreateNode(item, null);
                node.BaseColor = this.groupColor[0];
                this.radDiagram1.AddShape(node);
                currentLayoutSettings.Roots.Add(node);
                this.GetSubNodes(item, node, 2);

            }
            Program.IsStart = true;
        }

        private ObservableCollection<OrgContainerShape> GetSubNodes(AlimexDAL.Entity.Organization element, OrgContainerShape parent, int level)
        {
            var nodes = new ObservableCollection<OrgContainerShape>();
            var elements = _org.Where(x => x.Parent == element.Id).ToList();
            if (elements.Count == 0)
            {
                return nodes;
            }

            Random rnd = new Random();

            foreach (var subElement in elements)
            {
                OrgContainerShape node = this.CreateNode(subElement, parent);
                node.ShowCollapseButton = level < 3;
                if (subElement.Parent == 1)
                {
                    node.BaseColor = Color.FromArgb(rnd.Next(150), rnd.Next(150), rnd.Next(150));
                }
                //if (node.Path.Contains("Production"))
                //{
                //    node.BaseColor = this.groupColor[2];
                //}else
                //if (node.Path.Contains("Accounting"))
                //{
                //    node.BaseColor = this.groupColor[1];
                //}
                this.radDiagram1.AddShape(node);

                this.GetSubNodes(subElement, node, level + 1);
                nodes.Add(node);
            }

            return nodes;
        }
        private OrgContainerShape CreateNode(AlimexDAL.Entity.Organization element, OrgContainerShape parentNode)
        {
            OrgContainerShape orgTeam = new OrgContainerShape(_userContext)
            {
                Name = element.Name,
            };
            orgTeam.ToggleCollapseButton.ImagePrimitive.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            orgTeam.Text = orgTeam.Name;
            orgTeam.Tag = element.Id.ToString();
            orgTeam.Path = parentNode == null ? orgTeam.Name : string.Format("{0}|{1}", parentNode.Path, orgTeam.Name);
            currentLayoutSettings.Roots.Add(orgTeam);
            if (parentNode != null)
            {
                RadDiagramConnection connection = new RadDiagramConnection();
                connection.ConnectionType = Telerik.Windows.Diagrams.Core.ConnectionType.Polyline;
                connection.Source = parentNode;
                connection.Target = orgTeam;

                this.radDiagram1.AddConnection(connection);
            }
            var teamMembers = this.GetTeamMembers(element, orgTeam);
            var position = new Telerik.Windows.Diagrams.Core.Point(10, 50);

            int memberCount = 0;
            foreach (var member in teamMembers)
            {
                this.radDiagram1.AddShape(member);
                orgTeam.Items.Add(member);
                member.Position = position;
                position.X += member.Width + 20;
                if (++memberCount % 2 == 0)
                {
                    position = new Telerik.Windows.Diagrams.Core.Point(10, position.Y + member.Height + 10);
                }
            }

            orgTeam.IsCollapsedChanged += this.orgTeam_IsCollapsedChanged;
            return orgTeam;
        }

        private ObservableCollection<RadDiagramShape> GetTeamMembers(AlimexDAL.Entity.Organization element, OrgContainerShape orgTeam)
        {
            var members = new ObservableCollection<RadDiagramShape>();
            if (element.Users != null)
                foreach (var xmlNodeMember in element.Users)
                {
                    RadDiagramShape member = this.CreateMemberShape(orgTeam, xmlNodeMember);
                    member.Tag = xmlNodeMember.Id;
                    members.Add(member);
                }

            return members;
        }


        private RadDiagramShape CreateMemberShape(OrgContainerShape team, User xmlNodeMember)
        {
            RadDiagramShape member = new RadDiagramShape();
            member.IsConnectorsManipulationEnabled = false;
            member.ForeColor = Color.White;
            member.IsRotationEnabled = false;
            member.IsResizingEnabled = false;
            member.Shape = new Telerik.WinControls.RoundRectShape(0);
            member.BackColor = Color.LightBlue;
            member.Width = 190;
            member.Height = 50;
            member.Tag = team;
            member.Name = xmlNodeMember.Name;
            member.DiagramShapeElement.TextAlignment = ContentAlignment.MiddleLeft;
            member.DiagramShapeElement.ImageLayout = ImageLayout.None;
            member.DiagramShapeElement.Padding = new System.Windows.Forms.Padding(5, 2, 2, 0);
            member.DiagramShapeElement.Image = null;//this.GetImageFromResource(member.Name);
            member.DiagramShapeElement.ImageAlignment = ContentAlignment.MiddleLeft;
            member.DiagramShapeElement.TextImageRelation = TextImageRelation.ImageBeforeText;
            member.DiagramShapeElement.TextWrap = false;
            member.Text = string.Format(" {0}\n {1}", member.Name, xmlNodeMember.Roles.Select(x => x.Name).FirstOrDefault());
            return member;
        }


        private void orgTeam_IsCollapsedChanged(object sender, Telerik.WinControls.UI.Diagrams.RoutedEventArgs e)
        {
            this.radDiagram1.SetLayout(Telerik.Windows.Diagrams.Core.LayoutType.Tree, currentLayoutSettings);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addTeam_Click( sender,  e);
            //RoleNode addRole = new RoleNode(_userContext.Organization.ToList(), this);
            //addRole.ShowDialog();
        }

        public void addUnit(string name, int parentId)
        {
            _userContext.Organization.Add(new AlimexDAL.Entity.Organization() { Name = name, Parent = parentId });
            _userContext.SaveChanges();
            //OrganizationShemaForm NewForm = new OrganizationShemaForm();
            //NewForm.Show();
            //this.Dispose(false);
        }

        public void addMember(string UserId, int organizationId)
        {
            var userIDGuid = Guid.Parse(UserId);
            var user = _userContext.Users.Where(x => x.Id == userIDGuid).FirstOrDefault();
            user.Organizations.Add(_userContext.Organization.Where(x => x.Id == organizationId).FirstOrDefault());
            _userContext.SaveChanges();
            //OrganizationShemaForm NewForm = new OrganizationShemaForm();
            //NewForm.Show();
            //this.Dispose(false);
        }

       public void addTeam_Click(object sender, EventArgs e)
        {
            var parent =this.radDiagram1.Shapes.ToList();
            //var parentTeam = this.FindAncestor<OrgContainerShape>();
            var newTeam = new OrgContainerShape(_userContext)
            {
                //Name = "New " + parentTeam.Tag.ToString() + " Team",
                //BaseColor = parentTeam.BaseColor,
            };

            //parentTeam.ShowCollapseButton = true;
            //newTeam.ToggleCollapseButton.ImagePrimitive.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            //newTeam.Text = newTeam.Name;
            //newTeam.Tag = parentTeam.Tag.ToString();
            //newTeam.Path = string.Format("{0}|{1}", parentTeam.Path, newTeam.Name);
            //newTeam.TeamMembers = string.Format("0 Team Members");
            //newTeam.ShowCollapseButton = false;
            //OrganizationShemaForm.currentLayoutSettings.Roots.Add(newTeam);

            //var diagramElement = this.FindAncestor<RadDiagramElement>();
            //diagramElement.AddShape(newTeam);

            //RadDiagramConnection connection = new RadDiagramConnection();
            //connection.ConnectionType = Telerik.Windows.Diagrams.Core.ConnectionType.Polyline;
            //connection.Source = parentTeam;
            //connection.Target = newTeam;
            //connection.Route = true;
            //diagramElement.AddConnection(connection);

            //diagramElement.SetLayout(Telerik.Windows.Diagrams.Core.LayoutType.Tree, OrganizationShemaForm.currentLayoutSettings);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            var addRole = new AddUserDialog(_userContext.Organization.ToList(), _userContext.Users.ToList(), this);
            addRole.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            var image = radDiagram1.ExportToImage();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Bitmap Image (.bmp)|*.bmp";
            save.ShowDialog();
            if (!String.IsNullOrEmpty(save.FileName))
                image.Save(save.FileName);

        }
    }
}
